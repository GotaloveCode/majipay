namespace MajiPay
{
    public interface INavigable
    {
        void Activate(object parameter);
        void Deactivate(object parameter);
        //bool AllowGoBack();
    }
}
