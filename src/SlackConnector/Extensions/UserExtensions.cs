﻿using SlackConnector.Connections.Models;
using SlackConnector.Models;

namespace SlackConnector.Extensions
{
    internal static class UserExtensions
    {
        public static SlackUser ToSlackUser(this User user)
        {
            var slackUser = new SlackUser
            {
                Id = user.Id,
                Name = user.Name,
                TimeZoneOffset = user.TimeZoneOffset,
                IsBot = user.IsBot
            };

            if (!string.IsNullOrWhiteSpace(user.Presence))
            {
                slackUser.Online = user.Presence == "active";
            }

            return slackUser;
        }
    }
}