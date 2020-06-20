﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// RoomWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RoomWindow : Window
    {
        //id所属
        public string id { get; set; }
        //对象
        private User item;
        //上面哪两个对于登录信息有用，勿删

        public RoomWindow()
        {
            InitializeComponent();
            item = CC.GetUser(id);
        }

        public string UserName
        {
            get { return username.Text; }
            set { username.Text = value +"快选择一个房间开始游戏吧！"; }
        }
    }
}
