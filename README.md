# PingPongCsharp
 C# 版物件導向PingPong

## Action 
- IAction interface 動作介面
- IDrawable interface 畫圖介面

## Object
- GameObject 所有遊戲物件的抽象 class 實作 IDrawable
- Ball 繼承 GameObject 實作 IAction
- Paddle 繼承 GameObject 實作 IAction
- Wall 繼承 GameObject