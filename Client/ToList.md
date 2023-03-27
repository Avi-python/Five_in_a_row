#製作清單

## Programs
- 沒有必要生成兩個
- GameManager似乎也沒有需要存在
## 流程
- 板子在還沒有輪到你的時候先稍稍透明
- 玩家離開時要把room刪掉。
- 判斷勝負
- 我覺得可以改成統一我方使用白棋，敵方就是黑棋，或是可以別的顏色

## 結尾
- 要做判斷
- 對方退出，直接進入下一個隊列

## 中離
- 還沒配對就離開。
- 對戰中中離。
需要傳訊息到Client，告知以及重新棋盤。
對方需要也需要處理，對方之後也退出，也會發訊息要檢查Server怎麼處理這個訊息(敵人已經不在了)
-> 由於我直接把對方加入對列裡面，所以不會再去跑enemy判斷式。
## 功能未完全
- Reset button
- 選擇玩家?
- 圖片的淡化，會閃一下
- 跳出視窗告訴使用者獲勝的消息，並讓他決定要不要繼續玩。
不玩->關掉應用程式
玩->重新排入隊列

##Thread
- 處理結束Thread的問題
因為Thread只要工作完就會繳回線程，所以我其實不用Abort，他執行的就是Listen函式，
而Listen函式裡面有個無窮迴圈再跑，我只要跳出去迴圈結束函式就可以結束這個線程了。

##Server
- 要刪掉下線的玩家

## bug
- 不知道為什麼，會出現顛倒的bug，也許。
- 你是先手 + 對手消息(反了)
- 棋盤要更新
- (消息)你的敵人是顯示錯誤
- 伺服器斷線要把System消息清空
- Server在Client無意間段開連結或瘋狂報錯，可能是因為Client沒有順利關掉。
- match出問題v -> 當一個被重新放入對列的，跟一個新來的match不上。

##防呆
- 最一開始要判斷沒有輸入東西的情況，防呆