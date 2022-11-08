using Newtonsoft.Json;
using System;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.Predictions
{
    public class Prediction
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
        [JsonProperty(PropertyName = "broadcaster_id")]
        public string BroadcasterId { get; protected set; }
        [JsonProperty(PropertyName = "broadcaster_name")]
        public string BroadcasterName { get; protected set; }
        [JsonProperty(PropertyName = "broadcaster_login")]
        public string BroadcasterLogin { get; protected set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "winning_outcome_id")]
        public string WinningOutcomeId { get; protected set; }
        [JsonProperty(PropertyName = "outcomes")]
        public Outcome[] Outcomes { get; protected set; }
        [JsonProperty(PropertyName = "prediction_window")]
        public int PredictionWindow { get; protected set; }
        [JsonProperty(PropertyName = "status")]
        public PredictionStatus Status { get; protected set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; protected set; }
        [JsonProperty(PropertyName = "ended_at")]
        public DateTime? EndedAt { get; protected set; }
        [JsonProperty(PropertyName = "locked_at")]
        public DateTime? LockedAt { get; protected set; }
    }
}
