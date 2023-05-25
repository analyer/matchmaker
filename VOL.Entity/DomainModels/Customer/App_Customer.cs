using Newtonsoft.Json;
/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "客户信息表",TableName = "App_Customer")]
    public partial class App_Customer:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [MaxLength(36)]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///修改人Id
       /// </summary>
       [Display(Name ="修改人Id")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       public string Modifier { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建人Id
       /// </summary>
       [Display(Name ="创建人Id")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///服务红娘
       /// </summary>
       [Display(Name ="服务红娘")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MatchmakerName { get; set; }

       /// <summary>
       ///红娘Id
       /// </summary>
       [Display(Name ="红娘Id")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? MatchmakerId { get; set; }

       /// <summary>
       ///门店Id
       /// </summary>
       [Display(Name ="门店Id")]
       [MaxLength(36)]
       [JsonIgnore]
       [Column(TypeName="uniqueidentifier")]
       public Guid? StoreId { get; set; }

       /// <summary>
       ///门店
       /// </summary>
       [Display(Name ="门店")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Store { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Gender { get; set; }

       /// <summary>
       ///年龄
       /// </summary>
       [Display(Name ="年龄")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Age { get; set; }

       /// <summary>
       ///客户等级
       /// </summary>
       [Display(Name ="客户等级")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string Level { get; set; }

       /// <summary>
       ///客户分类
       /// </summary>
       [Display(Name ="客户分类")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string Classification { get; set; }

       /// <summary>
       ///详细住址
       /// </summary>
       [Display(Name ="详细住址")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Address { get; set; }

       /// <summary>
       ///区县
       /// </summary>
       [Display(Name ="区县")]
       [MaxLength(10)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(10)")]
       public string DistrictCounty { get; set; }

       /// <summary>
       ///城市
       /// </summary>
       [Display(Name ="城市")]
       [MaxLength(10)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(10)")]
       public string City { get; set; }

       /// <summary>
       ///省份
       /// </summary>
       [Display(Name ="省份")]
       [MaxLength(10)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(10)")]
       public string Province { get; set; }

       /// <summary>
       ///联系方式
       /// </summary>
       [Display(Name ="联系方式")]
       [MaxLength(15)]
       [Column(TypeName="nvarchar(15)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PhoneNo { get; set; }

       /// <summary>
       ///昵称
       /// </summary>
       [Display(Name ="昵称")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string NickName { get; set; }

       /// <summary>
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [MaxLength(6)]
       [Column(TypeName="nvarchar(6)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///头像图片URL
       /// </summary>
       [Display(Name ="头像图片URL")]
       [MaxLength(255)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(255)")]
       public string HeadPictureUrl { get; set; }

       
    }
}
