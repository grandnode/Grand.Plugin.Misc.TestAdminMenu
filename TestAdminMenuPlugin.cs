using Grand.Core.Plugins;
using Grand.Framework.Menu;
using Grand.Services.Common;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace Grand.Plugin.Misc.TestAdminMenu
{
    public class TestAdminMenuPlugin : BasePlugin, IMiscPlugin, IAdminMenuPlugin
    {
        #region Ctor
        public TestAdminMenuPlugin() { }

        #endregion

        #region Methods

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            base.Uninstall();
        }

        public void ManageSiteMap(Framework.Menu.SiteMapNode rootNode)
        {

            //plugins
            if (rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Plugins") == null)
            {
                rootNode.ChildNodes.Add(new Framework.Menu.SiteMapNode()
                {
                    SystemName = "Plugins",
                    Title = "Plugins",
                    Visible = true,
                    IconClass = "fa fa-plug",
                });
            }

            var menus = new List<SiteMapNode>
            {
                new Grand.Framework.Menu.SiteMapNode
                {
                    Title = "PLUGINS level 1",
                    Visible = true,
                    SystemName = "TestAdminMenu",
                    IconClass = "fa fa-spinner fa-spin fa-3x fa-fw",
                    ControllerName = "TestAdminMenu",
                    ActionName = "Configure",
                    RouteValues = new RouteValueDictionary() { { "area", null } },
                },
                new Grand.Framework.Menu.SiteMapNode
                {
                    Title = "PLUGINS level 2",
                    Visible = true,
                    SystemName = "TestAdminMenu",
                    IconClass = "fa fa-circle-o-notch fa-spin fa-3x fa-fw",
                    ControllerName = "TestAdminMenu",
                    ActionName = "Configure",
                    RouteValues = new RouteValueDictionary() { { "area", null } },
                    ChildNodes =   new List<SiteMapNode>{
                        new Grand.Framework.Menu.SiteMapNode
                        {
                            Title = "PLUGINS level 2.1",
                            Visible = true,
                            SystemName = "TestAdminMenu",
                            IconClass = "fa fa-refresh fa-spin fa-3x fa-fw",
                            ControllerName = "TestAdminMenu",
                            ActionName = "Configure",
                            RouteValues = new RouteValueDictionary() { { "area", null } },
                        },
                        new Grand.Framework.Menu.SiteMapNode
                        {
                            Title = "PLUGINS level 2.2",
                            Visible = true,
                            SystemName = "TestAdminMenu",
                            IconClass = "fa fa-refresh fa-spin fa-3x fa-fw",
                            ControllerName = "TestAdminMenu",
                            ActionName = "Configure",
                            RouteValues = new RouteValueDictionary() { { "area", null } },
                        }
                    }
                }
            };

            foreach (var menu in menus)
                rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Plugins").ChildNodes.Add(menu);

            //extensions
            if (rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Extensions") == null)
            {
                rootNode.ChildNodes.Add(new Framework.Menu.SiteMapNode()
                {
                    SystemName = "Extensions",
                    Title = "Extensions",
                    Visible = true,
                    IconClass = "fa fa-plug",
                });
            }

            var menus1 = new List<SiteMapNode>
            {
                new Grand.Framework.Menu.SiteMapNode
                {
                    Title = "EXTENSIONS level 1",
                    Visible = true,
                    SystemName = "ExtensionsTestAdminMenu",
                    IconClass = "fa fa-spinner fa-spin fa-3x fa-fw",
                    ControllerName = "TestAdminMenu",
                    ActionName = "Configure",
                    RouteValues = new RouteValueDictionary() { { "area", null } },
                },
                new Grand.Framework.Menu.SiteMapNode
                {
                    Title = "EXTENSIONS level 2",
                    Visible = true,
                    SystemName = "ExtensionsTestAdminMenu",
                    IconClass = "fa fa-circle-o-notch fa-spin fa-3x fa-fw",
                    ControllerName = "TestAdminMenu",
                    ActionName = "Configure",
                    RouteValues = new RouteValueDictionary() { { "area", null } },
                    ChildNodes =   new List<SiteMapNode>{
                        new Grand.Framework.Menu.SiteMapNode
                        {
                            Title = "EXTENSIONS level 2.1",
                            Visible = true,
                            SystemName = "ExtensionsTestAdminMenu",
                            IconClass = "fa fa-refresh fa-spin fa-3x fa-fw",
                            ControllerName = "TestAdminMenu",
                            ActionName = "Configure",
                            RouteValues = new RouteValueDictionary() { { "area", null } },
                        }
                    }
                }
            };

            foreach (var menu in menus1)
                rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Extensions").ChildNodes.Add(menu);
        }

        #endregion
    }
}