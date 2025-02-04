﻿
public class TwitchSubscriber : PacketHandler<TwitchSubscription>
{
    public TwitchSubscriber(
        GameManager game,
        RavenBotConnection server,
        PlayerManager playerManager)
        : base(game, server, playerManager)
    {
    }

    public override void Handle(TwitchSubscription data, GameClient client)
    {
        Game.Twitch.OnSubscribe(data);
    }
}