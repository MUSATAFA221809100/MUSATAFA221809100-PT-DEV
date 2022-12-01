VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H80000004&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Hesap Makinesi"
   ClientHeight    =   2460
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   3225
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2460
   ScaleWidth      =   3225
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton Option4 
      Caption         =   "Bölme"
      Height          =   495
      Left            =   1560
      TabIndex        =   5
      Top             =   1320
      Width           =   1215
   End
   Begin VB.OptionButton Option3 
      Caption         =   "Çarpma"
      Height          =   495
      Left            =   240
      TabIndex        =   4
      Top             =   1320
      Width           =   1215
   End
   Begin VB.OptionButton Option2 
      Caption         =   "Çýkarma"
      Height          =   495
      Left            =   1560
      TabIndex        =   3
      Top             =   720
      Width           =   1215
   End
   Begin VB.OptionButton Option1 
      Caption         =   "Toplama"
      Height          =   495
      Left            =   240
      TabIndex        =   2
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox a2 
      Height          =   495
      Left            =   1920
      TabIndex        =   1
      Top             =   120
      Width           =   975
   End
   Begin VB.TextBox a1 
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   975
   End
   Begin VB.Label c4 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   29.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1320
      TabIndex        =   7
      Top             =   0
      Width           =   375
   End
   Begin VB.Label cevap 
      Caption         =   "Cevap"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   240
      TabIndex        =   6
      Top             =   1800
      Width           =   2655
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Option1_Click()
cevap.Caption = Val(a1) + Val(a2)
c4.Caption = "+"
End Sub

Private Sub Option2_Click()
cevap.Caption = Val(a1) - Val(a2)
c4.Caption = " -"
End Sub

Private Sub Option3_Click()
cevap.Caption = Val(a1) * Val(a2)
c4.Caption = "x"
End Sub

Private Sub Option4_Click()
cevap.Caption = Val(a1) / Val(a2)
c4.Caption = " /"
End Sub
