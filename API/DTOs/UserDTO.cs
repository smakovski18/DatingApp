using System;

namespace API.DTOs;

public class UserDTO
{
    public required string Id { get; set; }
    public required string Email { get; set; } = string.Empty;    
    public required string DisplayName { get; set; } = string.Empty;
    public string? imageUrl { get; set; }   
    public string Token { get; set; } = string.Empty;
}
