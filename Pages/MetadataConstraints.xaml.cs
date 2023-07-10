/*
Copyright 2022 Esri
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.​
*/

using ArcGIS.Desktop.Metadata;
using ArcGIS.Desktop.Metadata.Editor.Pages;

namespace IPRMetadata.Pages
{
    internal class MetadataConstraintsSidebarLabel : ISidebarLabel
    {
        string ISidebarLabel.SidebarLabel
        {
            get { return MetadataConstraintsSidebarLabel.SidebarLabel; }
        }

        public static string SidebarLabel
        {
            get { return IPRMetadata.Properties.Resources.CFG_LBL_METADATACONSTRAINTS; }
        }
    }
    /// <summary>
    /// Interaction logic for MTK_MetadataConstraints.xaml
    /// </summary>
    internal partial class MTK_MetadataConstraints : EditorPage
    {
        public MTK_MetadataConstraints()
        {
            InitializeComponent();
        }

        public override string SidebarLabel
        {
            get { return MetadataConstraintsSidebarLabel.SidebarLabel; }
        }
    }
}
