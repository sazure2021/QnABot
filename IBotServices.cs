using Microsoft.Bot.Builder.AI.QnA;

namespace Microsoft.BotBuilderSamples
{
    public interface IBotServices
    {
        QnAMaker QnAMakerService { get; }
    }
}
