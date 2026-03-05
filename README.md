# 🌾 智慧农业监控系统 (AgricultureApp)

<div align="center">

![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-9.0-512BD4?style=flat-square&logo=.net)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS%20%7C%20Windows-blue?style=flat-square)
![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)

一款基于 .NET MAUI 开发的跨平台智慧农业管理应用

</div>

## 📖 项目简介

智慧农业监控系统是一款现代化的农业物联网管理应用,采用 .NET 9 和 MAUI 框架开发,支持 Android、iOS、Windows 多平台部署。
## ✨ 核心功能

### 🎥 实时视频监控样式
- 多路视频流实时预览
- 横向滚动的视频列表布局
- 一键播放视频监控画面
- 支持农田、大棚等多场景监控

### ⚠️ 智能异常预警样式
- 病虫害自动识别与预警
- 温湿度异常实时提醒
- 彩色图标分级显示异常严重程度
- 精准定位异常发生区域(田间/大棚)

### 🌡️ 气象站数据监测样式
实时监测 8 项关键环境参数:
- **温湿度监控**: 室外温度、湿度变化趋势
- **风力监测**: 风向、瞬时风速实时数据
- **雨量统计**: 瞬时雨量累计分析
- **光照分析**: 紫外线强度、光照强度
- **气压监测**: 大气压力变化

### 📊 数据可视化
- 卡片式数据展示,简洁直观
- 动态颜色标识(绿色/橙色/红色)表示数据状态
- 数据变化趋势箭头提示
- 支持自定义刷新时间和数据分析

## 🛠️ 技术栈

| 技术 | 说明 |
|------|------|
| **框架** | .NET MAUI 9.0 |
| **语言** | C# 12 |
| **架构** | MVVM (Model-View-ViewModel) |
| **平台支持** | Android 5.0+, iOS 15.0+, Windows 10+ |
| **数据绑定** | Data Binding + CollectionView |

## 📱 应用截图

### 主界面预览
![主界面](https://github.com/OnlyACry/AgricultureApp/blob/master/Pictures/FarmPage.png)

### 底部导航
- 🌾 **农场**: 农田监控与气象站数据
- 🏠 **大棚**: 温室大棚专项管理
- 👤 **我的**: 个人设置与系统配置

## 🚀 快速开始

### 环境要求
- Visual Studio 2022 (17.8+)
- .NET 9.0 SDK
- Android SDK / Xcode (根据目标平台)
