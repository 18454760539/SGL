
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace denturepc
{


    public class Global : System.Web.HttpApplication
    {
        //public static staff st;
        protected void Application_Start(object sender, EventArgs e)
        {
            //感觉浪费性能每个都走一遍 如果需要前台处理
            JsonSerializerSettings setting = new JsonSerializerSettings();
            JsonConvert.DefaultSettings = () =>
            {
                setting.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
                setting.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                return setting;
            };


        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            context.Response.ContentType = "text/plain";

            string requesturl = context.Request.Url.AbsolutePath;
            //如果访问根目录则直接跳转到首页
            if (requesturl == "/")
            {
                Response.Redirect("/admin/start/index.html",false); context.Response.End(); return;
            }



        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            //截获报错
            var mesindex = context.Request.Url.Segments.Length;
            var mes = context.Request.Url.Segments;
            var type = context.Request.Url.Query;
            string arr ="";
            if (!string.IsNullOrEmpty(type))
            {
                var ad = type.Split('=');
                if (ad.Length>0)
                {
                    arr = ad[1].Split('&')[0];
                }
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }


        protected void Application_End(object sender, EventArgs e)
        {
          //访问量写入
        }




        /// <summary>
        /// global权限鉴权
        /// </summary>
        /// <param name="index"></param>
        /// <param name="st"></param>
        /// <param name="context"></param>
        public void globaljq(int index, HttpContext context)
        {

        }
        

    }

}