// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Markdig.Syntax;
using CommunityToolkit.Labs.WinUI.MarkdownTextBlock.TextElements;

namespace CommunityToolkit.Labs.WinUI.MarkdownTextBlock.Renderers.ObjectRenderers;

internal class ParagraphRenderer : UWPObjectRenderer<ParagraphBlock>
{
    protected override void Write(WinUIRenderer renderer, ParagraphBlock obj)
    {
        if (renderer == null) throw new ArgumentNullException(nameof(renderer));
        if (obj == null) throw new ArgumentNullException(nameof(obj));

        var paragraph = new MyParagraph(obj, renderer);
        // set style
        renderer.Push(paragraph);
        renderer.WriteLeafInline(obj);
        renderer.Pop();
    }
}
