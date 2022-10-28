# MusicPlayer_v1.0

#ĐỒ ÁN LẬP TRÌNH TRỰC QUAN IT008 - N13 GIÁO VIÊN HƯỚNG DẪN - ĐINH NGUYỄN ANH DŨNG


NHÓM SINH VIÊN THỰC HIỆN: 
<br>Phạm Quốc Danh - 21520178
<br>Nguyễn Cao Hoài - xxxxxxx
<br>
*Description:

# DASHBOARD
![image](https://user-images.githubusercontent.com/93357243/195901825-09dfc8dd-b1ac-4c1b-b085-9e1486daa62b.png)

```csharp
if (holding != null) //We'll check, even though you should have logic to not be able to try move if you don't hold anything
{
    //Check if it's contained as a legal move
    if (!holding.LegalMoves.Contains(to))
    {
        //You might wanna cancel the current move here

        return; //assuming this is a function
    }

    //This function tells if your piece (usually a pawn) is about to be promoted
    if (board.IsPromotable(holding.Parent, to))
    {
        //Handle promotion...
    }

    //Finally tell the board to move the piece
    board.Move(holding.Parent, to, currentPromoteOption);
}
```

