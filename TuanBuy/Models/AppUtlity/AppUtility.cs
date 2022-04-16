﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuanBuy.Models.AppUtlity
{
    public class AppUtility
    {
        /// <summary>
        /// 手動建立Configuration取連線字串
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static IConfiguration getConfiguration(params string[] settings)
        {
            //使用工廠模式 手動產生
                
            var builder = new ConfigurationBuilder().SetBasePath(System.IO.Directory.GetCurrentDirectory());
            //走訪配置幾個
            foreach (string filename in settings)
            {
                builder.AddJsonFile(filename);
            }   
            //去要一個組態物件      
            return builder.Build();
        }

        //傳遞Timestamp 長整數 轉換成DateTime結構
        public static DateTime convertLongToDateTime(long timestamp)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(timestamp);
            DateTime curDate = new DateTime(1970, 1, 1) + time;
            return curDate;
        }
    }
}
