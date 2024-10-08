﻿using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace HTMLQuestPDF.Extensions
{
    internal static class IContainerExtensions
    {
#if DEBUG
        private static Random random = new Random();

        public static IContainer Debug(this IContainer container, string name) => container.DebugArea(name, String.Format("#{0:X6}", random.Next(0x1000000)));
#endif
        public static IContainer Align(this IContainer container, string alignment)
        {
            return alignment.ToLower() switch
            {
                "" => container.AlignLeft(),
                "ql-align-right" => container.AlignRight(),
                "right" => container.AlignRight(),
                "ql-align-center" => container.AlignCenter(),
                "center" => container.AlignCenter(),
                _ => container.AlignLeft()
            };
        }
    }
}