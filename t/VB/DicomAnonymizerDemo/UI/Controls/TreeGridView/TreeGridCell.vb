﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
'---------------------------------------------------------------------
' 
'  Copyright (c) Microsoft Corporation.  All rights reserved.
' 
'THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
'KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'PARTICULAR PURPOSE.
'---------------------------------------------------------------------
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles
Imports System.Diagnostics

Namespace DicomAnonymizer.UI.Controls
   ''' <summary>
   ''' Summary description for TreeGridCell.
   ''' </summary>
   Public Class TreeGridCell : Inherits DataGridViewTextBoxCell
      Private Const INDENT_WIDTH As Integer = 20
      Private Const INDENT_MARGIN As Integer = 5
      Private glyphWidth As Integer
      Private calculatedLeftPadding As Integer
      Friend IsSited As Boolean
      Private _previousPadding As Padding
      Private _imageWidth As Integer = 0, _imageHeight As Integer = 0, _imageHeightOffset As Integer = 0

      Public Sub New()
         glyphWidth = 15
         calculatedLeftPadding = 0
         Me.IsSited = False

      End Sub

      Public Overrides Function Clone() As Object
         Dim c As TreeGridCell = CType(MyBase.Clone(), TreeGridCell)

         c.glyphWidth = Me.glyphWidth
         c.calculatedLeftPadding = Me.calculatedLeftPadding

         Return c
      End Function

      Protected Friend Overridable Sub UnSited()
         ' The row this cell is in is being removed from the grid.
         Me.IsSited = False
         Me.Style.Padding = Me._previousPadding
      End Sub

      Protected Friend Overridable Sub Sited()
         ' when we are added to the DGV we can realize our style
         Me.IsSited = True

         ' remember what the previous padding size is so it can be restored when unsiting
         Me._previousPadding = Me.Style.Padding

         Me.UpdateStyle()
      End Sub

      Protected Friend Overridable Sub UpdateStyle()
         ' styles shouldn't be modified when we are not sited.
         If Me.IsSited = False Then
            Return
         End If

         Dim level_Renamed As Integer = Me.Level
         Dim p As Padding = Me._previousPadding
         Dim preferredSize As Size

         Using g As Graphics = Me.OwningNode._grid.CreateGraphics()
            preferredSize = Me.GetPreferredSize(g, Me.InheritedStyle, Me.RowIndex, New Size(0, 0))
         End Using

         Dim image As Image = Me.OwningNode.Image

         If Not image Is Nothing Then
            ' calculate image size
            _imageWidth = image.Width + 2
            _imageHeight = image.Height + 2

         Else
            _imageWidth = glyphWidth
            _imageHeight = 0
         End If

         ' TODO: Make this cleaner
         If preferredSize.Height < _imageHeight Then

            Me.Style.Padding = New Padding(p.Left + (level_Renamed * INDENT_WIDTH) + _imageWidth + INDENT_MARGIN, CType(p.Top + (_imageHeight / 2), Integer), p.Right, CType(p.Bottom + (_imageHeight / 2), Integer))
            _imageHeightOffset = 2 ' (_imageHeight - preferredSize.Height) / 2;
         Else
            Me.Style.Padding = New Padding(p.Left + (level_Renamed * INDENT_WIDTH) + _imageWidth + INDENT_MARGIN, p.Top, p.Right, p.Bottom)

         End If

         calculatedLeftPadding = ((level_Renamed - 1) * glyphWidth) + _imageWidth + INDENT_MARGIN
      End Sub

      Public ReadOnly Property Level() As Integer
         Get
            Dim row As TreeGridNode = Me.OwningNode
            If Not row Is Nothing Then
               Return row.Level
            Else
               Return -1
            End If
         End Get
      End Property

      Protected Overridable ReadOnly Property GlyphMargin() As Integer
         Get
            Return ((Me.Level - 1) * INDENT_WIDTH) + INDENT_MARGIN
         End Get
      End Property

      Protected Overridable ReadOnly Property GlyphOffset() As Integer
         Get
            Return ((Me.Level - 1) * INDENT_WIDTH)
         End Get
      End Property

      Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)

         Dim node As TreeGridNode = Me.OwningNode
         If node Is Nothing Then
            Return
         End If

         Dim image As Image = node.Image

         If Me._imageHeight = 0 AndAlso Not image Is Nothing Then
            Me.UpdateStyle()
         End If

         ' paint the cell normally
         MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

         ' TODO: Indent width needs to take image size into account
         Dim glyphRect As Rectangle = New Rectangle(cellBounds.X + Me.GlyphMargin, cellBounds.Y, INDENT_WIDTH, cellBounds.Height - 1)
         Dim glyphHalf As Integer = CType(glyphRect.Width / 2, Integer)

         'TODO: This painting code needs to be rehashed to be cleaner
         Dim level_Renamed As Integer = Me.Level

         'TODO: Rehash this to take different Imagelayouts into account. This will speed up drawing
         '		for images of the same size (ImageLayout.None)
         If Not image Is Nothing Then
            Dim pp As Point
            If _imageHeight > cellBounds.Height Then
               pp = New Point(glyphRect.X + Me.glyphWidth, cellBounds.Y + _imageHeightOffset)
            Else
               pp = New Point(glyphRect.X + Me.glyphWidth, CType(((cellBounds.Height / 2 - _imageHeight / 2) + cellBounds.Y), Integer))
            End If

            ' Graphics container to push/pop changes. This enables us to set clipping when painting
            ' the cell's image -- keeps it from bleeding outsize of cells.
            Dim gc As System.Drawing.Drawing2D.GraphicsContainer = graphics.BeginContainer()
            graphics.SetClip(cellBounds)
            graphics.DrawImageUnscaled(image, pp)
            graphics.EndContainer(gc)
         End If

         ' Paint tree lines			
         If node._grid.ShowLines Then
            Using linePen As Pen = New Pen(SystemBrushes.ControlDark, 1.0F)
               linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
               Dim isLastSibling As Boolean = node.IsLastSibling
               Dim isFirstSibling As Boolean = node.IsFirstSibling
               If node.Level = 1 Then
                  ' the Root nodes display their lines differently
                  If isFirstSibling AndAlso isLastSibling Then
                     ' only node, both first and last. Just draw horizontal line
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                  ElseIf isLastSibling Then
                     ' last sibling doesn't draw the line extended below. Paint horizontal then vertical
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                     graphics.DrawLine(linePen, glyphRect.X + 4, cellBounds.Top, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                  ElseIf isFirstSibling Then
                     ' first sibling doesn't draw the line extended above. Paint horizontal then vertical
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.X + 4, cellBounds.Bottom)
                  Else
                     ' normal drawing draws extended from top to bottom. Paint horizontal then vertical
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                     graphics.DrawLine(linePen, glyphRect.X + 4, cellBounds.Top, glyphRect.X + 4, cellBounds.Bottom)
                  End If
               Else
                  If isLastSibling Then
                     ' last sibling doesn't draw the line extended below. Paint horizontal then vertical
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                     graphics.DrawLine(linePen, glyphRect.X + 4, cellBounds.Top, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                  Else
                     ' normal drawing draws extended from top to bottom. Paint horizontal then vertical
                     graphics.DrawLine(linePen, glyphRect.X + 4, CType(cellBounds.Top + cellBounds.Height / 2, Integer), glyphRect.Right, CType(cellBounds.Top + cellBounds.Height / 2, Integer))
                     graphics.DrawLine(linePen, glyphRect.X + 4, cellBounds.Top, glyphRect.X + 4, cellBounds.Bottom)
                  End If

                  ' paint lines of previous levels to the root
                  Dim previousNode As TreeGridNode = node.Parent
                  Dim horizontalStop As Integer = (glyphRect.X + 4) - INDENT_WIDTH

                  Do While Not previousNode.IsRoot
                     If previousNode.HasChildren AndAlso (Not previousNode.IsLastSibling) Then
                        ' paint vertical line
                        graphics.DrawLine(linePen, horizontalStop, cellBounds.Top, horizontalStop, cellBounds.Bottom)
                     End If
                     previousNode = previousNode.Parent
                     horizontalStop = horizontalStop - INDENT_WIDTH
                  Loop
               End If

            End Using
         End If

         If node.HasChildren OrElse node._grid.VirtualNodes Then
            ' Paint node glyphs				
            If node.IsExpanded Then
                    graphics.DrawImage(node._grid.rOpen, New Point(glyphRect.X - 5, glyphRect.Y))
            Else
                    graphics.DrawImage(node._grid.rClosed, New Point(glyphRect.X - 5, glyphRect.Y))
            End If
         End If
      End Sub
      Protected Overrides Sub OnMouseUp(ByVal e As DataGridViewCellMouseEventArgs)
         MyBase.OnMouseUp(e)

         Dim node As TreeGridNode = Me.OwningNode
         If Not node Is Nothing Then
            node._grid._inExpandCollapseMouseCapture = False
         End If
      End Sub
      Protected Overrides Sub OnMouseDown(ByVal e As DataGridViewCellMouseEventArgs)
         If e.Location.X > Me.InheritedStyle.Padding.Left Then
            MyBase.OnMouseDown(e)
         Else
            ' Expand the node
            'TODO: Calculate more precise location
            Dim node As TreeGridNode = Me.OwningNode
            If Not node Is Nothing Then
               node._grid._inExpandCollapseMouseCapture = True
               If node.IsExpanded Then
                  node.Collapse()
               Else
                  node.Expand()
               End If
            End If
         End If
      End Sub
      Public ReadOnly Property OwningNode() As TreeGridNode
         Get
            Return TryCast(MyBase.OwningRow, TreeGridNode)
         End Get
      End Property
   End Class

   Public Class TreeGridColumn : Inherits DataGridViewTextBoxColumn
      Friend _defaultNodeImage As Image

      Public Sub New()
         Me.CellTemplate = New TreeGridCell()
      End Sub

      ' Need to override Clone for design-time support.
      Public Overrides Function Clone() As Object
         Dim c As TreeGridColumn = CType(MyBase.Clone(), TreeGridColumn)
         c._defaultNodeImage = Me._defaultNodeImage
         Return c
      End Function

      Public Property DefaultNodeImage() As Image
         Get
            Return _defaultNodeImage
         End Get
         Set(ByVal value As Image)
            _defaultNodeImage = Value
         End Set
      End Property
   End Class
End Namespace
