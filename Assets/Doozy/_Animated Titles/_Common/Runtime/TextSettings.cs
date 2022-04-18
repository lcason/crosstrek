// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using System;

namespace Doozy._Animated_Titles._Common.Runtime
{
    [Serializable]
    public class TextSettings
    {
        public string gameObjectName { get; }
        public string defaultText { get; }
        public int defaultFontSize { get; }
            
        public string GameObjectName;
        public string Text;
        public int FontSize;

        public TextSettings(string gameObjectName, string defaultText, int defaultFontSize)
        {
            this.gameObjectName = gameObjectName;
            this.defaultText = defaultText;
            this.defaultFontSize = defaultFontSize;
            GameObjectName = gameObjectName;
            Text = defaultText;
            FontSize = defaultFontSize;
        }

        public void Reset()
        {
            GameObjectName = gameObjectName;
            Text = defaultText;
            FontSize = defaultFontSize;
        }
    }
}
