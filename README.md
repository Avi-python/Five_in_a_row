# This is a GoBang game Project
## class Player
- 儲存玩家數據
- 控制玩家的動作
## classTable
- 儲存棋盤數據
- 要設計一個"打包"函式，把棋盤轉成記號可以傳給Server端
## class GameManager
### 控制遊戲流程
- 玩家先連線，連到彼此，決定先後
### 掌握規則
- 控制這個玩家可不可以下
- 贏了要傳勝利消息
### 清除重玩
- 兩邊需要協議 
## 收入玩家的指令變更棋盤
- 網路方面
- 需要一個收聽Server指示的接口

## 消息口號
### 1:接受廣播消息
- 消息會傳給所有其他人

### 2:接受私密訊息
- 消息只有特定人會接收到

### 3:Server訊息
- 你是先手
- 你是後手
- 勝利消息
- Server控管換誰下棋
