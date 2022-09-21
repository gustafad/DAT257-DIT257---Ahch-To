using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace CarCompare.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.auto-data.net/", IsNullable = false)]
    


    public partial class CarDataDTO
    {

        private brandsBrand[] brandField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("brand")]
        public brandsBrand[] brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    public partial class brandsBrand
    {

        private string updateField;

        private string nameField;

        private ushort idField;

        private brandsBrandModel[] modelsField;

        /// <remarks/>
        public string update
        {
            get
            {
                return this.updateField;
            }
            set
            {
                this.updateField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("model", IsNullable = false)]
        public brandsBrandModel[] models
        {
            get
            {
                return this.modelsField;
            }
            set
            {
                this.modelsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    public partial class brandsBrandModel
    {

        private string updateField;

        private string nameField;

        private ushort idField;

        private brandsBrandModelGeneration[] generationsField;

        /// <remarks/>
        public string update
        {
            get
            {
                return this.updateField;
            }
            set
            {
                this.updateField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("generation", IsNullable = false)]
        public brandsBrandModelGeneration[] generations
        {
            get
            {
                return this.generationsField;
            }
            set
            {
                this.generationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    public partial class brandsBrandModelGeneration
    {

        private byte prototypeField;

        private string updateField;

        private string nameField;

        private ushort modelYearField;

        private bool modelYearFieldSpecified;

        private ushort idField;

        private brandsBrandModelGenerationImage[] imagesField;

        private brandsBrandModelGenerationModification[] modificationsField;

        /// <remarks/>
        public byte prototype
        {
            get
            {
                return this.prototypeField;
            }
            set
            {
                this.prototypeField = value;
            }
        }

        /// <remarks/>
        public string update
        {
            get
            {
                return this.updateField;
            }
            set
            {
                this.updateField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort modelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modelYearSpecified
        {
            get
            {
                return this.modelYearFieldSpecified;
            }
            set
            {
                this.modelYearFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public brandsBrandModelGenerationImage[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("modification", IsNullable = false)]
        public brandsBrandModelGenerationModification[] modifications
        {
            get
            {
                return this.modificationsField;
            }
            set
            {
                this.modificationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    public partial class brandsBrandModelGenerationImage
    {

        private uint idField;

        private string updateField;

        private string smallField;

        private string bigField;

        private string attributionField;

        /// <remarks/>
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string update
        {
            get
            {
                return this.updateField;
            }
            set
            {
                this.updateField = value;
            }
        }

        /// <remarks/>
        public string small
        {
            get
            {
                return this.smallField;
            }
            set
            {
                this.smallField = value;
            }
        }

        /// <remarks/>
        public string big
        {
            get
            {
                return this.bigField;
            }
            set
            {
                this.bigField = value;
            }
        }

        /// <remarks/>
        public string attribution
        {
            get
            {
                return this.attributionField;
            }
            set
            {
                this.attributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.auto-data.net/")]
    public partial class brandsBrandModelGenerationModification
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("acceleration", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("acceleration200", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("acceleration300", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("acceleration60", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("allElectricRange", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("allElectricRangeMax", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("allElectricRangeMin", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("averageEnergyConsumption", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("averageEnergyConsumptionMax", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("averageEnergyConsumptionMin", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("batteryCapacity", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("batteryCapacityNet", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("brand", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("co2", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("co2Max", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("co2Min", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("coupe", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("deceleration", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("deceleration200", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("drive", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor2Power", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor2PowerHp", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor2PowerRpm", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor2PowerRpmHigh", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor2PowerRpmLow", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor3Power", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor3PowerHp", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor3PowerRpm", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor3PowerRpmLow", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor4Power", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotor4PowerHp", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotorPower", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotorPowerHp", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotorPowerRpm", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotorPowerRpmHigh", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("electricMotorPowerRpmLow", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("emissionStandard", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("fuelConsumptionCombined", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("fuelConsumptionCombinedMax", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("fuelConsumptionCombinedMin", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("generation", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("id", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("maxspeed", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("model", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("places", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("placesMax", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("placesMin", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("standardCO2", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("standardEVc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("standardEVr", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("standardFCc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("update", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("yearstart", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("yearstop", typeof(ushort))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.auto-data.net/", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        acceleration,

        /// <remarks/>
        acceleration200,

        /// <remarks/>
        acceleration300,

        /// <remarks/>
        acceleration60,

        /// <remarks/>
        allElectricRange,

        /// <remarks/>
        allElectricRangeMax,

        /// <remarks/>
        allElectricRangeMin,

        /// <remarks/>
        averageEnergyConsumption,

        /// <remarks/>
        averageEnergyConsumptionMax,

        /// <remarks/>
        averageEnergyConsumptionMin,

        /// <remarks/>
        batteryCapacity,

        /// <remarks/>
        batteryCapacityNet,

        /// <remarks/>
        brand,

        /// <remarks/>
        co2,

        /// <remarks/>
        co2Max,

        /// <remarks/>
        co2Min,

        /// <remarks/>
        coupe,

        /// <remarks/>
        deceleration,

        /// <remarks/>
        deceleration200,

        /// <remarks/>
        drive,

        /// <remarks/>
        electricMotor2Power,

        /// <remarks/>
        electricMotor2PowerHp,

        /// <remarks/>
        electricMotor2PowerRpm,

        /// <remarks/>
        electricMotor2PowerRpmHigh,

        /// <remarks/>
        electricMotor2PowerRpmLow,

        /// <remarks/>
        electricMotor3Power,

        /// <remarks/>
        electricMotor3PowerHp,

        /// <remarks/>
        electricMotor3PowerRpm,

        /// <remarks/>
        electricMotor3PowerRpmLow,

        /// <remarks/>
        electricMotor4Power,

        /// <remarks/>
        electricMotor4PowerHp,

        /// <remarks/>
        electricMotorPower,

        /// <remarks/>
        electricMotorPowerHp,

        /// <remarks/>
        electricMotorPowerRpm,

        /// <remarks/>
        electricMotorPowerRpmHigh,

        /// <remarks/>
        electricMotorPowerRpmLow,

        /// <remarks/>
        emissionStandard,

        /// <remarks/>
        fuelConsumptionCombined,

        /// <remarks/>
        fuelConsumptionCombinedMax,

        /// <remarks/>
        fuelConsumptionCombinedMin,

        /// <remarks/>
        generation,

        /// <remarks/>
        id,

        /// <remarks/>
        maxspeed,

        /// <remarks/>
        model,

        /// <remarks/>
        places,

        /// <remarks/>
        placesMax,

        /// <remarks/>
        placesMin,

        /// <remarks/>
        standardCO2,

        /// <remarks/>
        standardEVc,

        /// <remarks/>
        standardEVr,

        /// <remarks/>
        standardFCc,

        /// <remarks/>
        update,

        /// <remarks/>
        yearstart,

        /// <remarks/>
        yearstop,
    }


}