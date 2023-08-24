// <copyright file="KeePassStringFieldsPasswordFontExt.cs" company="Aaron Papp">
// Copyright (c) 2023 Aaron Papp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.
// </copyright>

using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;
using System;
using System.Linq;

namespace KeePassStringFieldsPasswordFont
{
    /// <summary>
    /// The main KeePass plugin class.
    /// </summary>
    public class KeePassStringFieldsPasswordFontExt : Plugin
    {
#pragma warning disable S1075 // URIs should not be hardcoded
        private static readonly Uri UpdateUri = new Uri("https://raw.githubusercontent.com/Aaron-P/KeePassStringFieldsPasswordFont/master/version.txt", UriKind.Absolute);
#pragma warning restore S1075 // URIs should not be hardcoded

        private IPluginHost host;

        /// <summary>
        /// Gets the url to check for the latest plugin version information.
        /// </summary>
        public override string UpdateUrl
        {
            get
            {
                return UpdateUri.AbsoluteUri;
            }
        }

        /// <summary>
        /// Initializes the KeePass plugin.
        /// </summary>
        /// <param name="host">An <see cref="IPluginHost"/> object.</param>
        /// <returns><see langword="true"/> if initialization was successful; otherwise, <see langword="false"/>.</returns>
        public override bool Initialize(IPluginHost host)
        {
            if (host == null)
                return false;

            this.host = host;
            GlobalWindowManager.WindowAdded += GlobalWindowManager_WindowAdded;
            return true;
        }

        /// <summary>
        /// Terminates the KeePass plugin.
        /// </summary>
        public override void Terminate()
        {
            if (host == null)
                return;

            GlobalWindowManager.WindowAdded -= GlobalWindowManager_WindowAdded;
            host = null;
        }

        private void GlobalWindowManager_WindowAdded(object sender, GwmWindowEventArgs e)
        {
            if (!(e.Form is EditStringForm))
                return;

            // this.m_rtbValue.Name = "m_rtbValue" on .\KeePass-2.54-Source\KeePass\Forms\EditStringForm.Designer.cs#L88
            var control = e.Form.Controls.Find("m_rtbValue", true).SingleOrDefault();
            if (control == null)
                return;

            FontUtil.AssignDefaultMono(control, true);
        }
    }
}
