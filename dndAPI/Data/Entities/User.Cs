namespace dndAPI.Data.Entities;

public class User
{
    public string id { get; set; }
    public string? nickName { get; set; }
    public string? email { get; set; }
    public string? password { get; set; }
    public string? createdAt { get; set; }
    public string? updatedAt { get; set; }
    public string? deleted { get; set; }
}