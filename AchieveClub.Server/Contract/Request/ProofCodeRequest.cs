﻿using System.ComponentModel.DataAnnotations;

namespace AchieveClub.Server.Contract.Request
{
    public record ProofCodeRequest([Required, EmailAddress] string EmailAddress, [Required, Range(1000, 9999)] int ProofCode);
}
