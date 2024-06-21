Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class BlueButton
    Inherits Button

    Private _buttonBackColor As Color = Color.FromArgb(179, 220, 250)
    Private _buttonForeColor As Color = Color.Black

    Public Property ButtonBackColor As Color
        Get
            Return _buttonBackColor
        End Get
        Set(value As Color)
            _buttonBackColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property ButtonForeColor As Color
        Get
            Return _buttonForeColor
        End Get
        Set(value As Color)
            _buttonForeColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 20
        Dim path As GraphicsPath = GetRoundedRect(rect, radius)

        Me.Region = New Region(path)

        Dim buttonRect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim brush As New SolidBrush(_buttonBackColor)

        graphics.FillPath(brush, path)
        TextRenderer.DrawText(graphics, Me.Text, Me.Font, buttonRect, _buttonForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class
