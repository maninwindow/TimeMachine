<Window x:Class="TimeMachine.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="DispatcherTimerSample" Height="150" Width="250">
    <Grid Background="BlanchedAlmond">
        <TextBlock FontSize="50" Margin="200,-12,175,258" RenderTransformOrigin="1.443,0.195">Timer</TextBlock>
        <TextBlock x:Name="clocktxtblock" FontSize="70" Margin="118,38,37,183"></TextBlock>
        <Button x:Name="startbtn" Margin="38,137,350,126" Background="SkyBlue" Content="Start" FontSize="30" Click="startbtn_Click" ></Button>
        <Button x:Name="stopbtn" Margin="200,137,190,126" Background="SkyBlue" Content="Stop" FontSize="30" Click="stopbtn_Click" ></Button>
        <Button x:Name="resetbtn" Margin="360,137,28,126" Background="SkyBlue" Content="Reset" FontSize="30" Click="resetbtn_Click" ></Button>
        <ListBox x:Name="elapsedtimeitem" HorizontalAlignment="Left" Height="100" VerticalAlignment="Top" Width="433" Margin="56,199,0,0" />
    </Grid>
</Window>