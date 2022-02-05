using System;


namespace BaseLib
{
    public abstract class BaseRemoteObject:MarshalByRefObject
    {
        public abstract void setValue(int pvalue);
        public abstract int getValue();
        public abstract string getText();
    }
}
