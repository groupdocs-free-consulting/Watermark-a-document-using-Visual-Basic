Imports System.IO
Imports GroupDocs.Watermark
Imports GroupDocs.Watermark.Common
Imports GroupDocs.Watermark.Watermarks
Module Module1

    Sub Main()

        Dim lic As License = New License
        lic.SetLicense("D:/GroupDocs.Total.NET.lic")

        Dim watermarker As Watermarker = New Watermarker("D:/sample.pdf")
        Dim watermark As TextWatermark = New TextWatermark("Protected", New Font("Arial", 36))
        watermark.ForegroundColor = Color.Red
        watermark.Opacity = 0.5
        watermark.TextAlignment = TextAlignment.Right
        watermark.HorizontalAlignment = HorizontalAlignment.Center
        watermark.VerticalAlignment = VerticalAlignment.Center
        watermark.RotateAngle = -45
        watermarker.Add(watermark)
        watermarker.Save(Path.Combine("D:/watermark output.pdf"))

    End Sub

End Module
