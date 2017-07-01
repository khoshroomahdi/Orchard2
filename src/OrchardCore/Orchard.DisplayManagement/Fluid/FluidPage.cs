﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;

namespace Orchard.DisplayManagement.Fluid
{
    public class FluidPage : Razor.RazorPage<dynamic>
    {
        public override async Task ExecuteAsync()
        {
            await FluidViewTemplate.RenderAsync(this);
        }

        public T GetService<T>()
        {
            return Context.RequestServices.GetService<T>();
        }

        [RazorInject]
        public IUrlHelper Url { get; private set; }

        [RazorInject]
        public IHtmlHelper Html { get; private set; }

        [RazorInject]
        public IViewComponentHelper Component { get; private set; }
    }
}