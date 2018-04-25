﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Wox.Plugin.Guid
{
    public sealed class GuidGenerator : IPlugin
    {
        private const string ImagePath = "images/guid.png";

        public void Init(PluginInitContext context)
        {
        }

        public List<Result> Query(Query query)
        {
            var guid = System.Guid.NewGuid().ToString();

            return new List<Result>
            {
                new Result
                {
                    Title = guid,                    
                    IcoPath = ImagePath,
                    Action = e =>
                    {
                        Clipboard.SetText(guid);
                        return true;
                    }
                },

                new Result
                {
                    Title = guid.ToUpper(),
                    IcoPath = ImagePath,
                    Action = e =>
                    {
                        Clipboard.SetText(guid);
                        return true;
                    }
                }
            };
        }
    }
}
