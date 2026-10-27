using AssetsTools.NET.Extra;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LunarsUABEA.Plugins
{
    public interface UABEAPluginOption
    {
        public bool SelectionValidForPlugin(AssetsManager am, UABEAPluginAction action, List<AssetContainer> selection, out string name);
        public Task<bool> ExecutePlugin(Window win, AssetWorkspace workspace, List<AssetContainer> selection);
    }
}
