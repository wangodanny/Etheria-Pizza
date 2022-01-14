namespace EtheriaPizza
{
    private class CustDetailBase
    {
        public virtual string FullDetail
        {
            get
            {
                return this.Name + this.Street + this.Postcode + this.Phone;
            }
        }
        public override string FullDetail
        {
            get
            {
                return this.Name + this.Street + this.Postcode + this.Phone;
            }
        }
    }
}