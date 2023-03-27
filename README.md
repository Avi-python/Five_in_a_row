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
- 你是先手 + 對手消息
- 你是後手 + 對手消息
- 勝利消息 + 同樣也要刪調房間

### 4:User -> Server
- Server控管換誰下棋
- 我下棋結束了
- 格式: 4<UserName>|<x>,<y>

### 5:Server -> User 
- 等待

### 6:User <-> Server <-> User
- 互相傳送的消息

### 7:Rematch User->Server
- 把傳過來的User重新加入排隊列中
### 8:勝利消息
- User 傳的那一方就代表他贏了
- User 收的那一方就代表他輸了
### 9:
- Server -> User : 表示你的敵人中離了
- User -> Server : 該User中離(關掉視窗)