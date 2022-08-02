using Worsoon.Attributes;

namespace Worsoon.ESql.Models;

public abstract class UserBase
{
    [Hello(Name = "Id", IsPrimaryKey = true, IsIdentity = true, DisplayName = "编号")]
    public long Id { get; set; }
    [Hello(Name = "Name", DisplayName = "登录名", Unique = true, StringLength = 16, TypeFor = "varchar")]
    public string? Name { get; set; }
    [Hello(Name = "Password", DisplayName = "密码", StringLength = 64, TypeFor = "varchar")]
    public string? Password { get; set; }
    [Hello(Name = "Role", DisplayName = "角色", StringLength = 8, TypeFor = "varchar")]
    public int RoleId { get; set; }
    [Hello(Name = "Email", DisplayName = "邮箱", StringLength = 128, TypeFor = "varchar")]
    public string? Email { get; set; }
}