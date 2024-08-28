using Models.Models.UserDetails;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Common
{
    public class JWTToken
    {
        public JwtSecurityToken GenerateJWTToken(IConfiguration configuration, User user)
        {
            DateTime expiryDate;

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            if (user.Role != null)
            {
                claims.Add(new Claim("Role", user.Role.RoleName));
                claims.Add(new Claim("Id", user.Id.ToString()));
            }

            var token = new JwtSecurityToken(
               issuer: configuration["JWT:ValidIssuer"],
               audience: configuration["JWT:ValidAudience"],
               expires: DateTime.Now.AddDays(1),
               claims: claims,
               signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }


        public JwtSecurityToken GenerateJWTTokenForResetPassword(IConfiguration configuration, User user)
        {
            DateTime expiryDate;

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            if (user.Role != null)
            {
                claims.Add(new Claim("Role", user.Role.RoleName));
                claims.Add(new Claim("Id", user.Id.ToString()));
            }

            var token = new JwtSecurityToken(
               issuer: configuration["JWT:ValidIssuer"],
               audience: configuration["JWT:ValidAudience"],
               expires: DateTime.Now.AddMinutes(30),
               claims: claims,
               signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }

        public string GetEmailFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();

            try
            {
                token = token?.Trim();

                if (!handler.CanReadToken(token))
                {
                    return null;
                }

                var jwtToken = handler.ReadJwtToken(token);

                var emailClaim = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "email" || claim.Type == ClaimTypes.Email);

                return emailClaim?.Value;
            }
            catch (ArgumentException ex)
            {

                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}