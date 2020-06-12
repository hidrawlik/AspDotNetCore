﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MusicPlayer.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MusicPlayer.API
{
    public class JWT
    {
        private readonly IConfiguration configuration;

        public JWT(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GenerateJwtToken(string email, UserDTO user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTConfiguration:JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(configuration["JWTConfiguration:JwtExpireDays"]));

            var token = new JwtSecurityToken(
                configuration["JWTConfiguration:JwtIssuer"],
                configuration["JWTConfiguration:JwtAudience"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
