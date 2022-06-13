using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length) => 
            new IdentityError { 
                Code = "PasswordTooShort", 
                Description = $"Parola en az {length} karakter olmalıdır." 
            };

        public override IdentityError PasswordRequiresUpper() =>
            new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 büyük harf içermelidir."
            };

        public override IdentityError PasswordRequiresLower() =>
            new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az 1 küçük harf içermelidir."
            };

        public override IdentityError PasswordRequiresNonAlphanumeric() =>
            new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az bir alfanumerik olmayan karaktere sahip olmalıdır."
            };

        public override IdentityError PasswordRequiresDigit() =>
            new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "Parola en az bir rakamdan ('0'-'9') oluşmalıdır."
            };
    }
}
