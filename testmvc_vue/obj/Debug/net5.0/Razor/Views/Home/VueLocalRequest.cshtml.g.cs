#pragma checksum "C:\Users\Paulo\source\repos\testmvc_vue\testmvc_vue\Views\Home\VueLocalRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807de7256c065e2593ea2b9cbb18accf20279221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VueLocalRequest), @"mvc.1.0.view", @"/Views/Home/VueLocalRequest.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Paulo\source\repos\testmvc_vue\testmvc_vue\Views\_ViewImports.cshtml"
using testmvc_vue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paulo\source\repos\testmvc_vue\testmvc_vue\Views\_ViewImports.cshtml"
using testmvc_vue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807de7256c065e2593ea2b9cbb18accf20279221", @"/Views/Home/VueLocalRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a1265cbff0c06420c70cd967976aaead4b473a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VueLocalRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Vue/vue.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Axios/axios.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Paulo\source\repos\testmvc_vue\testmvc_vue\Views\Home\VueLocalRequest.cshtml"
  
    ViewData["Title"] = "Vue Test1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"payloadJSON\"");
            BeginWriteAttribute("value", " value=\"", 84, "\"", 112, 1);
#nullable restore
#line 5 "C:\Users\Paulo\source\repos\testmvc_vue\testmvc_vue\Views\Home\VueLocalRequest.cshtml"
WriteAttributeValue("", 92, ViewBag.payloadJSON, 92, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
            WriteLiteral(@"<style>
    [v-cloak] {
        display: none;
    }

    .highlight {
        border: solid 3px red;
        color: red;
    }

    .shooting-star-leave-to, .shooting-star-enter {
        opacity: 0;
    }

    .neo-list-leave-to, .neo-list-enter {
        opacity: 0;
    }

</style>
");
            WriteLiteral("\r\n");
            WriteLiteral("<div id=\"app\">\r\n    <div class=\"container\">\r\n        <asteroid-grid v-on:remove=\"remove\" :asteroids=\"asteroids\" header=\"Requesting data from Local Server\"></asteroid-grid>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807de7256c065e2593ea2b9cbb18accf202792215504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807de7256c065e2593ea2b9cbb18accf202792216543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807de7256c065e2593ea2b9cbb18accf202792217582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<script>
Vue.component('asteroid-grid', {
    props: ['asteroids', 'header'],
    data: function() {
        return {
            showSummary: true
        }
    },
    computed: {
        numAsteroids: function() {
            return this.asteroids.length;
        },
        closestObject: function() {
            var neosHavingData = this.asteroids.filter(function(neo) {
                return neo.close_approach_data.length > 0;
            });
            var simpleNeos = neosHavingData.map(function(neo) {
                return {name: neo.name, miles: neo.close_approach_data[0].miss_distance.miles};
            });
            var sortedNeos = simpleNeos.sort(function(a, b) {
                return a.miles - b.miles;
            });
            return sortedNeos[0].name;
        }
    },
    methods: {
        getCloseApproachDate: function (a) {
            if (a.close_approach_data.length > 0) {
                return a.close_approach_data[0].close_approach_date;
           ");
            WriteLiteral(@" }
            return 'N/A';
        },
        remove: function (index) {
            this.$emit('remove', index);
        },
        getRowStyle: function (a) {
            if (a.close_approach_data.length == 0) {
                return {
                    border: 'solid 2px red',
                    color: 'red'
                }
            }
        },
        isMissingData: function (a) {
            return a.close_approach_data.length == 0;
        }
    },
    template: '<div class=""card mt-5""> \
                    <h2 class=""card-header"">{{header}}</h2> \
                    <transition name=""shooting-star""> \
                        <div class=""mt-3 ml-3"" v-cloak v-if=""numAsteroids > 0 && showSummary""> \
                            <p>showing {{numAsteroids}} items</p> \
                            <p>{{closestObject}} has the smallest miss distance.</p> \
                        </div> \
                    </transition> \
                    <div class=""m-3""> \
      ");
            WriteLiteral(@"                  <a href=""#"" v-on:click=""showSummary = !showSummary"">Show/hide summary</a> \
                    </div> \
                    <table class=""table table-striped"" :class=""[{\'table-dark\': false}, \'table-bordered\']""> \
                        <thead class=""thead-light""> \
                            <th>#</th> \
                            <th>Name</th> \
                            <th>Approach Date</th> \
                            <th>Closest Distance</th> \
                            <th></th> \
                        </thead> \
                        <tbody is=""transition-group"" name=""neo-list"" v-cloak> \
                            <tr v-for=""(a, index) in asteroids"" \
                                :key=""a.neo_reference_id"" \
                                :class=""{highlight: isMissingData(a), \'shadow-sm\': true}""> \
                                <td>{{index + 1}}</td> \
                                <td>{{a.name}}</td> \
                                <td>{");
            WriteLiteral(@"{getCloseApproachDate(a)}}</td> \
                                <td> \
                                    <ul v-if=""a.close_approach_data.length > 0""> \
                                        <li v-for=""(value, key) in a.close_approach_data[0].miss_distance""> \
                                            {{key}}: {{value}} \
                                        </li> \
                                    </ul> \
                                </td> \
                                <td><button class=""btn btn-warning"" v-on:click=""remove(index)"">remove</button></td> \
                             </tr> \
                        </tbody> \
                    </table> \
                </div>'
});
</script>
");
            WriteLiteral(@"<script>
    var vm = new Vue({
        el: '#app',
        data: {
            asteroids: []
        },
        created: function () {
            //this.fetchAsteroids();
            this.fetchAsteroidsLocal();
        },
        methods: {
            fetchAsteroids: function () {
                var apiKey = 'lkgI9to0hRizfzk4xTAxtNTTFkkA4Mtq7y1yW5me';
                var url = '/api/TestApi/IdVal';
                axios.get(url)
                    .then(function (res) {
                        vm.asteroids = res.data.near_earth_objects.slice(0, 10);
                    });
            },
            fetchAsteroidsLocal: function () {
                let payloadJSON = JSON.parse($(""#payloadJSON"").val());
                this.asteroids = payloadJSON.near_earth_objects.slice(0, 10);

                //------------
                //var apiKey = 'lkgI9to0hRizfzk4xTAxtNTTFkkA4Mtq7y1yW5me';
                //var url = '/api/TestApi/IdVal';
                //axios.get(url)
           ");
            WriteLiteral(@"     //    .then(function (res) {
                //        vm.asteroids = payloadJSON.near_earth_objects.slice(0, 10);
                //    });

                //------------

            },
            remove: function (index) {
                this.asteroids.splice(index, 1);
            },
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
