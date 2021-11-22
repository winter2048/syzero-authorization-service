using System;
using System.Collections.Generic;
using System.Text;
using SyZero.Application.Service.Dto;

namespace SyZero.Authorization.IApplication.Users.Dto
{
    public class CreateUserDto : EntityDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPicture { get; set; }

        /// <summary>
        /// 性别 0男 1女 2保密 
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int Type { get; set; } = 0;

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; } = 0;

        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// 验证码 
        /// </summary>
        public string VerificationCode { get; set; }
    }
}
