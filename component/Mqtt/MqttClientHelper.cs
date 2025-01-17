﻿// <copyright file="MqttClientHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Dgiot_dtu
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;
    using MQTTnet;
    using MQTTnet.Core;
    using MQTTnet.Core.Client;
    using MQTTnet.Core.Packets;
    using MQTTnet.Core.Protocol;

    public class MqttClientHelper
    {
        private MqttClientHelper()
        {
        }

        private static MqttClient mqttClient = null;
        private static string server = "prod.iotn2n.com";
        private static int port = 1883;
        private static string plctopic = "thing/plc/clientid/";
        private static string opcdatopic = "thing/opcda/clientid/";
        private static string opcuatopic = "thing/opcua/clientid/";
        private static string bacnettopic = "thing/bacnet/clientid/";
        private static string controltopic = "thing/control/clientid/";
        private static string accesstopic = "thing/access/clientid/";
        private static string sqlservertopic = "thing/sqlserver/clientid/";
        private static string subtopic = "thing/com/";
        private static string pubtopic = "thing/com/post/";
        private static string clientid = Guid.NewGuid().ToString().Substring(0, 5);
        private static string username = "dgiot";
        private static string password = "dgiot";
        private static MqttClientHelper instance = null;
        private static MainForm mainform = null;
        private static bool bIsRunning = false;
        private static bool bIsCheck = false;
        private static bool bAutoReconnect = false;

        public static MqttClientHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new MqttClientHelper();
            }

            return instance;
        }

        public static void Start(KeyValueConfigurationCollection config, bool bAutoReconnect, MainForm mainform)
        {
            Config(config, mainform);
            bIsRunning = true;
            MqttClientHelper.bAutoReconnect = bAutoReconnect;
            if (bIsCheck)
            {
                Task.Run(async () => { await ConnectMqttServerAsync(); });
            }
        }

        public static void Stop()
        {
            if (mqttClient != null)
            {
                bAutoReconnect = false;
                bIsRunning = false;
                Task.Run(async () => { await DisConnectMqttServerAsync(); });
            }
        }

        public static void Config(KeyValueConfigurationCollection config, MainForm mainform)
        {
            if (config["mqttServer"] != null)
            {
                server = (string)config["mqttServer"].Value;
            }

            if (config["mqttPort"] != null)
            {
                port = int.Parse((string)config["mqttPort"].Value);
            }

            if (config["mqttClientId"] != null)
            {
                clientid = (string)config["mqttClientId"].Value;
            }

            if (config["mqttUserName"] != null)
            {
                username = (string)config["mqttUserName"].Value;
            }

            if (config["mqttPassword"] != null)
            {
                password = (string)config["mqttPassword"].Value;
            }

            if (config["mqttSubTopic"] != null)
            {
                subtopic = (string)config["mqttSubTopic"].Value;
            }

            if (config["mqttPubTopic"] != null)
            {
                pubtopic = (string)config["mqttPubTopic"].Value;
            }

            if (config["mqttPubTopic"] != null)
            {
                pubtopic = (string)config["mqttPubTopic"].Value;
            }

            if (config["mqttPubTopic"] != null)
            {
                pubtopic = (string)config["mqttPubTopic"].Value;
            }

            if (config["mqttIsCheck"] != null)
            {
                bIsCheck = StringHelper.StrTobool(config["mqttIsCheck"].Value);
            }

            if (config["PLCTopic"] != null)
            {
                plctopic = config["PLCTopic"].Value;
            }

            if (config["OPCDATopic"] != null)
            {
                opcdatopic = config["OPCDATopic"].Value;
            }

            if (config["OPCUATopic"] != null)
            {
                opcuatopic = config["OPCUATopic"].Value;
            }

            if (config["BACnetTopic"] != null)
            {
                bacnettopic = config["BACnetTopic"].Value;
            }

            if (config["ControlTopic"] != null)
            {
                controltopic = config["ControlTopic"].Value;
            }

            if (config["AccessTopic"] != null)
            {
                accesstopic = config["AccessTopic"].Value;
            }

            if (config["SqlServerTopic"] != null)
            {
                sqlservertopic = config["SqlServerTopic"].Value;
            }

            MqttClientHelper.mainform = mainform;
        }

        public void Publish(byte[] payload)
        {
            var appMsg = new MqttApplicationMessage(pubtopic, payload, MqttQualityOfServiceLevel.AtLeastOnce, false);
            mqttClient.PublishAsync(appMsg);
        }

        public static void Publish(string pubtopic, byte[] payload)
        {
            var appMsg = new MqttApplicationMessage(pubtopic, payload, MqttQualityOfServiceLevel.AtLeastOnce, false);
            mqttClient.PublishAsync(appMsg);
        }

        private static async Task ReConnectMqttServerAsync()
        {
            while (bIsRunning)
            {
                if (!bAutoReconnect)
                {
                    break;
                }

                Thread.Sleep(1000 * 10);
                if (!mqttClient.IsConnected)
                {
                    await ConnectMqttServerAsync();
                }
            }
        }

        private static async Task ConnectMqttServerAsync()
        {
            if (mqttClient == null)
            {
                mqttClient = new MqttClientFactory().CreateMqttClient() as MqttClient;
                mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
                mqttClient.Connected += MqttClient_Connected;
                mqttClient.Disconnected += MqttClient_Disconnected;
            }

            try
            {
                var options = new MqttClientTcpOptions
                {
                    Server = server,
                    ClientId = clientid,
                    UserName = username,
                    Password = password,
                    Port = port,
                    CleanSession = true
                };

               await DisConnectMqttServerAsync();
               await mqttClient.ConnectAsync(options);
               await ReConnectMqttServerAsync();
            }
            catch (Exception ex)
            {
                mainform.Log(ex.ToString());
            }
        }

        private static async Task DisConnectMqttServerAsync()
        {
            try
            {
                await mqttClient.DisconnectAsync();
            }
            catch (Exception ex)
            {
                mainform.Log(ex.ToString());
            }
        }

        /// <summary>
        /// 服务器连接成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MqttClient_Connected(object sender, EventArgs e)
        {
            mainform.Log("mqtt client:" + clientid + " connected");
            mqttClient.SubscribeAsync(new TopicFilter(plctopic + "/#",  MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(opcdatopic + "/#",   MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(opcuatopic + "/#", MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(bacnettopic + "/#", MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(controltopic + "/#", MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(accesstopic + "/#", MqttQualityOfServiceLevel.AtLeastOnce));
            mqttClient.SubscribeAsync(new TopicFilter(sqlservertopic + "/#", MqttQualityOfServiceLevel.AtLeastOnce));
            mainform.Log("mqtt client subscribe topic: " + plctopic + "/#");
            mainform.Log("mqtt client subscribe topic: " + opcdatopic + "/#" );
            mainform.Log("mqtt client subscribe topic: " + opcuatopic + "/#");
            mainform.Log("mqtt client subscribe topic: " + bacnettopic + "/#");
            mainform.Log("mqtt client subscribe topic: " + controltopic + "/#" );
            mainform.Log("mqtt client subscribe topic: " + accesstopic + "/#" );
            mainform.Log("mqtt client subscribe topic: " + sqlservertopic + "/#" );
            mainform.Log("mqtt client subscribe topic: " + subtopic + "/#" );
        }

        /// <summary>
        /// 断开服务器连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MqttClient_Disconnected(object sender, EventArgs e)
        {
            if (bAutoReconnect)
            {
                _ = ReConnectMqttServerAsync();
            }
            else
            {
                mainform.Log("mqtt:" + clientid + " disconnected");
            }
        }

        /// <summary>
        /// 接收到消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Dictionary<string, object> json = Get_payload(e.ApplicationMessage.Payload);
            string topic = e.ApplicationMessage.Topic;
            string data = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            mainform.Log("mqtt recv:topic: " + e.ApplicationMessage.Topic.ToString() + " payload: " + data);

            Regex r_subtopic = new Regex(subtopic); // 定义一个Regex对象实例
            Match m_subtopic = r_subtopic.Match(e.ApplicationMessage.Topic); // 在字符串中匹配
            if (m_subtopic.Success)
            {
                SerialPortHelper.Write(e.ApplicationMessage.Payload, 0, e.ApplicationMessage.Payload.Length);
            }

            OPCDAHelper.Do_opc_da(mqttClient, topic, json, clientid, mainform);

            AccessHelper.Do_mdb(mqttClient, topic,  json, clientid, mainform);

            MqttServerHelper.Write(e.ApplicationMessage);
        }

        public static void Write(byte[] data, int offset, int len)
        {
            if (bIsCheck)
            {
                var appMsg = new MqttApplicationMessage(pubtopic + clientid, Encoding.UTF8.GetBytes(mainform.Logdata(data, offset, len)), MqttQualityOfServiceLevel.AtLeastOnce, false);
                mainform.Log("mqtt client publish:" + mainform.Logdata(data, offset, len));
                mqttClient.PublishAsync(appMsg);
           }
        }

        public static void Write(MqttApplicationMessage appMsg)
        {
            if (bIsCheck)
            {
                mqttClient.PublishAsync(appMsg);
            }
        }

        private static Dictionary<string, object> Get_payload(byte[] payload)
        {
            string data = Encoding.UTF8.GetString(payload);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> json = (Dictionary<string, object>)serializer.DeserializeObject(data);
            return json;
        }

        private static Dictionary<string, object> Get_payload(byte[] payload, int offset, int len)
        {
            string data = Encoding.UTF8.GetString(payload, offset, len);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> json = (Dictionary<string, object>)serializer.DeserializeObject(data);
            return json;
        }

        private static readonly DateTime BaseTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// 将unixtime转换为.NET的DateTime
        /// </summary>
        /// <param name="timeStamp">秒数</param>
        /// <returns>转换后的时间</returns>
        public static DateTime FromUnixTime(long timeStamp)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime((timeStamp * 10000000) + BaseTime.Ticks));
        }

        /// <summary>
        /// 将.NET的DateTime转换为unix time
        /// </summary>
        /// <param name="dateTime">待转换的时间</param>
        /// <returns>转换后的unix time</returns>
        public static long FromDateTime(DateTime dateTime)
        {
            return (TimeZone.CurrentTimeZone.ToUniversalTime(dateTime).Ticks - BaseTime.Ticks) / 10000000;
        }
    }
}