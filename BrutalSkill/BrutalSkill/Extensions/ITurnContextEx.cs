﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Security.Claims;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Connector.Authentication;

namespace BrutalSkill.Extensions
{
    public static class ITurnContextEx
    {
        public static bool IsSkill(this ITurnContext turnContext)
        {
            return turnContext.TurnState.Get<ClaimsIdentity>("BotIdentity") is ClaimsIdentity botIdentity && SkillValidation.IsSkillClaim(botIdentity.Claims) ? true : false;
        }
    }
}