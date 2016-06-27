using System;
using System.Runtime.Serialization;

namespace WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular.ObjectEnum
{
    [DataContract]
    [Serializable]
    public class ObjectEnum : IEquatable<ObjectEnum>
    {
        private int _internalValue;

        [Obsolete("Usage is forbidden", true)]
        [DataMember]
        public int InternalValue
        {
            get
            {
                return this._internalValue;
            }
            set
            {
                this._internalValue = value;
            }
        }

        public ObjectEnum()
        {
        }

        protected ObjectEnum(int value)
        {
            this._internalValue = value;
        }

        public static implicit operator int(ObjectEnum a)
        {
            return a._internalValue;
        }

        public static bool operator ==(ObjectEnum a, ObjectEnum b)
        {
            if (object.ReferenceEquals((object)a, (object)b))
                return true;
            if (a == null || b == null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(ObjectEnum a, ObjectEnum b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            ObjectEnum other = obj as ObjectEnum;
            if (other != (ObjectEnum)null)
                return this.Equals(other);
            return false;
        }

        public bool Equals(ObjectEnum other)
        {
            if (other == (ObjectEnum)null)
                return false;
            return this._internalValue == other._internalValue;
        }

        public override int GetHashCode()
        {
            return this._internalValue.GetHashCode();
        }

        public static T ToObject<T>(int internalValue) where T : ObjectEnum, new()
        {
            T instance = Activator.CreateInstance<T>();
            instance._internalValue = internalValue;
            return instance;
        }
    }
}