using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;

namespace LoveSilk.Common
{
    public class MessageHelper
    {
        /**
         * 服务http地址
         */
      

        /// <summary>
        /// 通用接口发短信
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static string sendSms(string mobile, out string telCode)
        {
            string cdkey = "6SDK-EMY-6688-KDXMQ";
            string password = "9826901";
            string BASE_URI = "http://sdk4rptws.eucp.b2m.cn:8080/sdkproxy/sendsms.action?";
            telCode = Number(6);

            string Meg = "【安邦医疗救援】提醒您：本次验证码为：" + telCode + "。请及时输入！验证码有效期为5分钟。请勿向任何人提供您本次接收的验证码！";
            if (Meg.Contains("key") || Meg.Contains("cd"))
            {
                return "-111";
            }

            else
            {
                BASE_URI = BASE_URI + "cdkey=" + cdkey + "&password=" + password + "&phone=" + mobile + "&message=" + Meg + "";
                string Result = GetPage(BASE_URI, "");
                if (Result.Contains("<error>0</error>"))
                {
                    return "0";
                }
                else
                {
                    return "-111";
                }
            }
        }

        /// <summary>
        /// 通用接口发短信
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static string sendSms(string mobile,string msg)
        {
            string cdkey = "6SDK-EMY-6688-KDXMQ";
            string password = "9826901";
            string BASE_URI = "http://sdk4rptws.eucp.b2m.cn:8080/sdkproxy/sendsms.action?";
            string Meg = "【安邦医疗救援】提醒您：" + msg;
            if (!Meg.Contains("-6688-"))
            {
                BASE_URI += "cdkey=" + cdkey + "&password=" + password + "&phone=" + mobile + "&message=" + Meg + "";
                string Result = GetPage(BASE_URI, "");
                if (Result.Contains("<error>0</error>"))
                {
                    return "0";
                }
                else
                {
                    return "-111";
                }
            }
            else
            {
                return "0";
            }
        }
        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <returns></returns>
        public static string Number(int Length)
        {
            string result = string.Empty;
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                result += random.Next(10).ToString();
            }
            return result;
        }


        /// <summary>
        /// 通用接口发短信-找回密码专用
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static string sendSms_pwd(string mobile, out string telCode)
        {
            string cdkey = "6SDK-EMY-6688-KDXMQ";
            string password = "9826901";
            string BASE_URI = "http://sdk4rptws.eucp.b2m.cn:8080/sdkproxy/sendsms.action?";
            telCode = mobile.Substring(4,6);

            string Meg = "【安邦医疗救援】提醒您：您的最新密码被修改为(注册账户后六位)：" + telCode + "。请登录系统至个人中心并及时修改密码。请勿向任何人提供您本次接收的信息！";
            if (Meg.Contains("key") || Meg.Contains("cd"))
            {
                return "-111";
            }
            else
            {
                BASE_URI = BASE_URI + "cdkey=" + cdkey + "&password=" + password + "&phone=" + mobile + "&message=" + Meg + "";
                string Result = GetPage(BASE_URI, "");
                if (Result.Contains("<error>0</error>"))
                {
                    return "0";
                }
                else
                {
                    return "-111";
                }
               
            }
        }

        /// <summary>
        /// 通用接口发短信-找回密码专用
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static string sendSms_pay(string mobile, out string telCode)
        {
            string cdkey = "6SDK-EMY-6688-KDXMQ";
            string password = "9826901";
            string BASE_URI = "http://sdk4rptws.eucp.b2m.cn:8080/sdkproxy/sendsms.action?";
            telCode = mobile.Substring(4, 6);

            string Meg = "【安邦医疗救援】提醒您：本次购买成功，我们的客服人员会尽快给您联系！您也可打电话‘400-608-6655’进行咨询";
            if (Meg.Contains("key") || Meg.Contains("cd"))
            {
                return "-111";
            }
            else
            {
                BASE_URI = BASE_URI + "cdkey=" + cdkey + "&password=" + password + "&phone=" + mobile + "&message=" + Meg + "";
                string Result = GetPage(BASE_URI, "");
                if (Result.Contains("<error>0</error>"))
                {
                    return "0";
                }
                else
                {
                    return "-111";
                }

            }
        }

        /// <param name="posturl">请求的URL</param>
        /// <param name="postData">发送的数据 Json格式</param>
        /// <returns>json格式的字符串  通过获取Key为：errcode的值，判断accessToken是否过期，如果返回值为：40001 则accessToken无效，需要重新获取。实例代码：请参考WX_SendNews类</returns>
        public static string GetPage(string posturl, string postData)
        {
            //WX_SendNews news = new WX_SendNews(); 
            //posturl： news.Posturl;
            //postData：news.PostData;
            System.IO.Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...  
            try
            {
                // 设置参数  
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据  
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求  
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码  
                string content = sr.ReadToEnd();
                string err = string.Empty;

                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }
    }
}