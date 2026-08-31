# 🌡️ 温湿度监控上位机系统

基于 **C# WinForms + Modbus RTU** 协议的工业级温湿度实时采集上位机软件，支持 RS485 总线对接 SHT30 等标准 Modbus 传感器，7×24 小时稳定运行。

![演示动画](./温湿度传感器演示动画.gif)

---

## 📋 项目亮点

| 亮点 | 说明 |
|------|------|
| 🏗️ **分层架构** | 多项目解耦：Modbus 通信库 / 自定义控件库 / 主程序，模块独立可复用 |
| 🔧 **自主 Modbus RTU** | 手写 03H 功能码 + 标准 CRC16 查表法校验，完整报文封装与异常校验 |
| ⚡ **异步无阻塞** | Task.Run 后台通信 + BeginInvoke 跨线程更新 UI，运行时界面丝滑 |
| 🛡️ **工业级容错** | 资源释放、输入校验、重入保护、IsDisposed 防关窗崩溃 |
| 📦 **可复用控件** | Thmeter / Hygromerter 柱状图控件，支持量程截断，可单独引用 |

---

## 🏛️ 架构设计
┌──────────────────┐ RS485总线 ┌───────────────┐ ModbusRTU ┌──────────────┐ │ SHT30 温湿度传感器 │ ◄──────────► │ USB-RS485 转换器│ ◄─────────────► │ FrmMain 主窗体 │ └──────────────────┘ └───────────────┘ └──────┬───────┘ │ │ 引用 ▼ ┌──────────────────┐ │ guan.MyControls │ │ Thmeter / │ │ Hygromerter │ └──────────────────┘





### 解决方案结构
guan.THProject/ ├── guan.ModbusBase/ # 控制台原型：Modbus RTU 最基础的收发验证 ├── guan.MoubusRTULib/ # 通信库：Connect / DisConnect / ReadHoldingRegister + CRC16 ├── guan.MyControls/ # 自定义控件库：柱状图温度计 Thmeter、柱状图湿度计 Hygromerter ├── WindowsFormsApp1/ # 主程序：WinForms 交互界面 └── guan.THProject.slnx # 解决方案文件





---

## 🛠️ 技术栈

- **语言**：C# 7.3
- **框架**：.NET Framework 4.8 / WinForms
- **通信**：System.IO.Ports（串口通信）
- **协议**：Modbus RTU v1.1（功能码 03H 读保持寄存器）
- **校验**：CRC16 查表法（Modbus RTU 标准，低字节在前）
- **异步**：Task.Run + Control.BeginInvoke

---

## 📦 硬件清单

| 设备 | 型号 | 说明 |
|------|------|------|
| 温湿度传感器 | SHT30-Modbus | 从站地址 1，寄存器 0=湿度(×0.1)，寄存器 1=温度(×0.1) |
| USB 转 RS485 | CH340 芯片 | 免驱，插上即识别为 COM 口 |
| 接线 | A 接 A，B 接 B | RS485 差分总线，注意极性不要接反 |

### 传感器参数
- 波特率：9600
- 数据位：8
- 校验位：None
- 停止位：1
- Modbus 从站地址：1

---

## 🚀 快速开始

### 环境要求
- Windows 10/11
- .NET Framework 4.8 SDK（VS2022 自带）
- Visual Studio 2022 或更高版本

### 运行步骤

1. **克隆仓库**
   ```bash
   git clone https://github.com/Motisama/guan.THProject.git
打开解决方案

双击 guan.THProject.slnx
配置串口

插上 USB-RS485 转换器，查看设备管理器分配的 COM 口号
运行主程序，在"串口号"下拉框选择对应的 COM 口
运行

按 F5 启动
点 "打 开 连 接" 按钮
每秒自动刷新温湿度数值
🔌 Modbus 协议说明
本项目实现 Modbus RTU 功能码 03H（读保持寄存器），报文格式如下：

请求报文（主机 → 从站）
字段	长度	说明
从站地址	1 字节	0x01
功能码	1 字节	0x03
起始地址	2 字节	大端序，如 0x0000
寄存器数量	2 字节	大端序，如 0x0002
CRC 校验	2 字节	低字节在前，高字节在后
应答报文（从站 → 主机）
字段	长度	说明
从站地址	1 字节	0x01
功能码	1 字节	0x03
字节计数	1 字节	4（2 个寄存器 × 2 字节）
寄存器 0 值	2 字节	湿度原始值
寄存器 1 值	2 字节	温度原始值
CRC 校验	2 字节	低字节在前
CRC16 校验
采用 Modbus RTU 标准 CRC16 查表法，多项式 0xA001，初始值 0xFFFF，返回顺序为 低字节在前、高字节在后。

🏗️ 工业级特性
特性	实现方式
异步通信不卡 UI	Task.Run 将串口操作放入线程池；通过 BeginInvoke 回主线程更新控件
资源安全释放	ModbusRTU 实现 IDisposable，支持 using 语法；FormClosing 确保串口关闭
跨线程保护	BeginInvoke + IsDisposed 检查，防止窗体关闭时后台线程访问已销毁的控件
重入保护	Interlocked.CompareExchange 保证同一时刻只有一个轮询任务在执行
输入容错	用户输入全部使用 int.TryParse 校验，避免格式异常打断运行
控件设计规范	自定义控件属性 setter 不弹 MessageBox，超量程静默截断（clamp）
📷 界面预览
界面预览

📁 版本历史
v1.1.0（当前版本）- 工业级改造
✅ 串口读取改为 Task.Run 异步执行，消除 UI 线程阻塞
✅ ModbusRTU 实现 IDisposable，支持 using 语法
✅ 跨线程 UI 更新改用 BeginInvoke + IsDisposed 保护
✅ Interlocked 重入保护，防止轮询任务堆积
✅ 输入校验改用 int.TryParse
✅ FormClosing 补充串口释放，修复 COM 端口占用问题
✅ 自定义控件移除 MessageBox，超量程静默截断
✅ 修复控制台原型 NullReferenceException
v1.0.0 - 初版
✅ 基本的 Modbus RTU 03H 读取功能
✅ WinForms 界面 + 自定义温湿度柱状图控件
✅ CRC16 查表法校验
✅ 定时器 1 秒轮询
📄 License
MIT License — 自由使用、修改、分发。

🤝 技术栈关键词
C# WinForms Modbus RTU System.IO.Ports 串口通信 RS485 CRC16 异步编程 Task.Run BeginInvoke IDisposable 工业上位机 工控软件
