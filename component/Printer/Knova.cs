﻿// <copyright file="AccessHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace Dgiot_dtu
{
    public class Knova
    {
        public string type { get; set; }
        public string text { get; set; }
        public string fontFamily { get; set; }
        public int fontSize { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
       
        //像素转为100之一英寸
        public static int pxToInch(int px)
        {
            return (int)(px * 100 / 96);
        }

        //英寸换算到厘米
        public decimal FromInchToCM(decimal inch)
        {
            return Math.Round((System.Convert.ToDecimal((inch / 100)) * System.Convert.ToDecimal(2.5400)), 2);  //Math.Round取两位小数
        }

        // 毫米转换成百分之一英寸
        public static int GetInch(float mm)
        {
            return (int)(mm * 0.0393700787402 * 100);
        }
    }

        //pt 磅或者点数，是point简称 1磅=0.03527厘米=1/72英寸
        //inch英寸， 1英寸=2.54厘米=96像素(分辨率为96dpi)
        //px 像素, pixel的简称（本表参照显示器96dbi显示进行换算，像素不能出现小数点，一般是取小显示
        //---------------------------------------------------
        //|中文字号  | 英文字号（磅）| 毫米      |  像素    |
        //---------------------------------------------------
        //| 1英寸    |  72pt         | 25.30mm   |  95.6px  |
        //---------------------------------------------------
        //| 大特号   |  63pt         | 22.14mm   |  83.7px  |
        //---------------------------------------------------
        //| 特号     |  54pt         | 18.97mm   |  71.7px  |
        //---------------------------------------------------
        //| 初号     |  42pt         | 14.82mm   |  56px    |
        //---------------------------------------------------
        //| 小初     |  36pt         | 12.70mm   |  48px    |
        //---------------------------------------------------
        //| 一号     |  26pt         | 9.17mm    |  34.7px  |
        //---------------------------------------------------
        //| 小一     |  24pt         | 8.47mm    |  32px    |
        //---------------------------------------------------
        //| 二号     |  22pt         | 7.76mm    |  29.3px  |
        //---------------------------------------------------
        //| 小二     |  18pt         | 6.35mm    |  24px    |
        //---------------------------------------------------
        //| 三号     |  16pt         | 5.64mm    |  21.3px  |
        //---------------------------------------------------
        //| 小三     |  15pt         | 5.29mm    |  20px    |
        //---------------------------------------------------
        //| 四号     |  14pt         | 4.94mm    |  18.7px  |
        //---------------------------------------------------
        //| 小四     |  12pt         | 4.23mm    |  16px    |
        //---------------------------------------------------
        //| 五号     |  10.5pt       | 3.70mm    |  14px    |
        //---------------------------------------------------
        //| 小五     |  9pt          | 3.18mm    |  12px    |
        //---------------------------------------------------
        //| 六号     |  7.5pt        | 2.56mm    |  10px    |
        //---------------------------------------------------
        //| 小六     |  6.5pt        | 2.29mm    |  8.7px   |
        //---------------------------------------------------
        //| 七号     |  5.5pt        | 1.94mm    |  7.3px   |
        //---------------------------------------------------
        //| 八号     |  5pt          | 1.76mm    |  6.7px   |
        //---------------------------------------------------

}