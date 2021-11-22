using System;
using SyZero.Domain.Entities;

namespace SyZero.Authorization.Core.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : Entity
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
        /// 密码
        /// </summary>
        public string Password { get; set; }

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
        /// 用户等级
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// 性别 0男 1女 2保密
        /// </summary>
        public int? Sex { get; set; }

        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string LastIP { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int Type { get; set; } = 0;

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; } = 0;

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? LastTime { get; set; }



    }
}



