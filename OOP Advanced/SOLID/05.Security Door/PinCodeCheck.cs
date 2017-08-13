namespace _05.Security_Door
{
    public class PinCodeCheck : SecurityCheck
    {
        private IPinCodeSecurity securityPin;

        public PinCodeCheck(IPinCodeSecurity securityPin)
        {
            this.securityPin = securityPin;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = securityPin.RequestPinCode();
            if (IsValid(pin))
            {
                return true;
            }

            return false;
        }
    }
}