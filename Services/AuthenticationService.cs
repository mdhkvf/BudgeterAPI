﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public string GetToken()
        {
            string tokenVal = "";

            var authClaims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "mhecky"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecureKeyTestingCharLength"));

            var token = new JwtSecurityToken(
                issuer: "http://dotnetdetail.net",
                audience: "http://dotnetdetail.net",
                expires: DateTime.Now.AddHours(8),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            try
            {
                tokenVal = new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                var xcep = ex;
            }

            return tokenVal;
        }
    }
}
