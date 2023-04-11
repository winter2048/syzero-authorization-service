using System;
using System.Collections.Generic;
using System.Text;
using SyZero.Application.Service.Dto;

namespace SyZero.Authorization.IApplication.Users.Dto
{
    public class UserDto : EntityDto
    {
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 性别 0男 1女 2保密 
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public string LastTime { get; set; }
        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string LastIP { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string PictureUrl { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
