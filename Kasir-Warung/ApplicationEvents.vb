Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed. This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication

        ' Diatur saat aplikasi start, sebelum form dibuat.
        ' DpiUnawareGdiScaled: render 96 DPI lalu diskalakan GDI+ agar layout 1100x730 tetap muat.
        Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
            ' Layar dengan skala >100% memotong layout 1100x730; GDI+ diskalakan agar tetap muat.
            e.HighDpiMode = HighDpiMode.DpiUnawareGdiScaled
            ' Font default aplikasi: Segoe UI 10 pt sesuai desain FormKasir
            e.Font = New Drawing.Font("Segoe UI", 10.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        End Sub

    End Class
End Namespace
