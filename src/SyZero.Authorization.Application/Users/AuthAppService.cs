using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using SyZero.Application.Service;
using SyZero.Authorization.Core.Users;
using SyZero.Authorization.IApplication.Users;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Authorization.Repository;
using SyZero.Cache;
using SyZero.Logger;
using SyZero.Runtime.Security;
using SyZero.Runtime.Session;
using SyZero.Serialization;
using SyZero.Web.Common;

namespace SyZero.Authorization.Application.Users
{
    public class AuthAppService : ApplicationService, IAuthAppService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICache _cache;
        private readonly ISyEncode _syEncode;
        private readonly IToken _token;
        private readonly IJsonSerialize _jsonSerialize;
        private readonly ILogger _logger;
        private readonly ISySession _sySeeion;

        public AuthAppService(IUserRepository userRepository,
           ICache cache,
           ISyEncode syEncode,
           IToken token,
           IJsonSerialize jsonSerialize,
           ILogger logger,
           ISySession sySeeion)
        {
            _userRepository = userRepository;
            _cache = cache;
            _syEncode = syEncode;
            _token = token;
            _jsonSerialize = jsonSerialize;
            _logger = logger;
            _sySeeion = sySeeion;
        }


        public async Task<bool> GetVerificationCode(string phone)
        {
            var user = await _userRepository.GetModelAsync(p => p.Phone == phone);
            if (user != null)
            {
                throw new SyMessageException("手机号已注册！");
            }
            string code = new Random().Next(1000, 9999).ToString();
            _cache.Set("VerificationCode:" + phone, code, 60 * 3);
            return true;
        }

        public async Task<string> Login(LoginDto input)
        {
            _logger.Info("登录：" + input.Phone);
            //var user = await _userRepository.GetModelAsync(p => (p.Phone == input.Phone || p.Name == input.UserName) && p.Password == _syEncode.Get32MD5One(input.PassWord) && p.Type == input.Type);
            //if (user == null)
            //{
            //    throw new SyMessageException("密码或账号不正确！");
            //}
            var user = new User();
            var claims = new[] {
                new Claim(SyClaimTypes.NickName,user.NickName??""),
                new Claim(SyClaimTypes.UserName,user.Name??""),
                new Claim(SyClaimTypes.AvatarUrl,user.HeadPicture??""),
                new Claim(SyClaimTypes.UserId,user.Id.ToString()),
                new Claim(SyClaimTypes.System,input.Type.ToString())
            };
            var accessToken = _token.CreateAccessToken(claims);
            _cache.Set("Token:" + user.Id, accessToken);
            return accessToken;
        }

        public async Task<bool> LogOut()
        {
            _cache.Remove("Token:" + SySession.UserId);
            return true;
        }

    

        public async Task<bool> Register(CreateUserDto input)
        {
            //验证验证码
            string vcode = _cache.Get<string>("VerificationCode:" + input.Phone);
            if (string.IsNullOrEmpty(vcode) || vcode != input.VerificationCode)
            {
                throw new SyMessageException("验证码错误！");
            }
            var user = await _userRepository.GetModelAsync(p => p.Phone == input.Phone && p.Type == input.Type);
            if (user != null)
            {
                throw new SyMessageException("手机号已注册！");
            }
            user = ObjectMapper.Map<User>(input);
            user.Password = _syEncode.Get32MD5One(input.NewPassword);
            user.CreateTime = DateTime.Now;
            var userAf = await _userRepository.AddAsync(user);
            if (userAf != null)
            {
                await _cache.RemoveAsync("VerificationCode:" + input.Phone);
            }
            return userAf != null;
        }
    }
}



