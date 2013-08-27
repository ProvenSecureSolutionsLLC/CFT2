using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// BETAFACE
namespace Bench
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceResponse
    {

        private int int_responseField;

        private string string_responseField;

        /// <remarks/>
        public int int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ImageRequestBinary
    {

        private string api_keyField;

        private string api_secretField;

        private string imagefile_dataField;

        private string original_filenameField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string imagefile_data
        {
            get
            {
                return this.imagefile_dataField;
            }
            set
            {
                this.imagefile_dataField = value;
            }
        }

        /// <remarks/>
        public string original_filename
        {
            get
            {
                return this.original_filenameField;
            }
            set
            {
                this.original_filenameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ImageRequestUrl
    {

        private string api_keyField;

        private string api_secretField;

        private string image_urlField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string image_url
        {
            get
            {
                return this.image_urlField;
            }
            set
            {
                this.image_urlField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceImageResponse
    {

        private int int_responseField;

        private string string_responseField;

        private string img_uidField;

        /// <remarks/>
        public int int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public string img_uid
        {
            get
            {
                return this.img_uidField;
            }
            set
            {
                this.img_uidField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ImageInfoRequestUid
    {

        private string api_keyField;

        private string api_secretField;

        private string img_uidField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string img_uid
        {
            get
            {
                return this.img_uidField;
            }
            set
            {
                this.img_uidField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ImageInfoRequestChecksum
    {

        private string api_keyField;

        private string api_secretField;

        private string img_checksumField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string img_checksum
        {
            get
            {
                return this.img_checksumField;
            }
            set
            {
                this.img_checksumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceImageInfoResponse
    {

        private int int_responseField;

        private string string_responseField;

        private string checksumField;

        private BetafaceImageInfoResponseFaces facesField;

        private string uidField;

        private string[] textField;

        /// <remarks/>
        public int int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public string checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFaces faces
        {
            get
            {
                return this.facesField;
            }
            set
            {
                this.facesField = value;
            }
        }

        /// <remarks/>
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFaces
    {

        private BetafaceImageInfoResponseFacesFaceInfo[] faceInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FaceInfo")]
        public BetafaceImageInfoResponseFacesFaceInfo[] FaceInfo
        {
            get
            {
                return this.faceInfoField;
            }
            set
            {
                this.faceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfo
    {

        private string image_uidField;

        private string uidField;

        private float ageField;

        private float age_confidenceField;

        private float angleField;

        private float beard_confidenceField;

        private string ethincityField;

        private float ethincity_confidenceField;

        private string genderField;

        private float gender_confidenceField;

        private float glasses_confidenceField;

        private float heightField;

        private BetafaceImageInfoResponseFacesFaceInfoMask_areas mask_areasField;

        private BetafaceImageInfoResponseFacesFaceInfoMeasurements measurementsField;

        private float mustache_confidenceField;

        private BetafaceImageInfoResponseFacesFaceInfoPoints pointsField;

        private float scoreField;

        private float smile_confidenceField;

        private BetafaceImageInfoResponseFacesFaceInfoTags tagsField;

        private BetafaceImageInfoResponseFacesFaceInfoUser_points user_pointsField;

        private float widthField;

        private float xField;

        private float yField;

        private string[] textField;

        /// <remarks/>
        public string image_uid
        {
            get
            {
                return this.image_uidField;
            }
            set
            {
                this.image_uidField = value;
            }
        }

        /// <remarks/>
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }

        /// <remarks/>
        public float age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        public float age_confidence
        {
            get
            {
                return this.age_confidenceField;
            }
            set
            {
                this.age_confidenceField = value;
            }
        }

        /// <remarks/>
        public float angle
        {
            get
            {
                return this.angleField;
            }
            set
            {
                this.angleField = value;
            }
        }

        /// <remarks/>
        public float beard_confidence
        {
            get
            {
                return this.beard_confidenceField;
            }
            set
            {
                this.beard_confidenceField = value;
            }
        }

        /// <remarks/>
        public string ethincity
        {
            get
            {
                return this.ethincityField;
            }
            set
            {
                this.ethincityField = value;
            }
        }

        /// <remarks/>
        public float ethincity_confidence
        {
            get
            {
                return this.ethincity_confidenceField;
            }
            set
            {
                this.ethincity_confidenceField = value;
            }
        }

        /// <remarks/>
        public string gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public float gender_confidence
        {
            get
            {
                return this.gender_confidenceField;
            }
            set
            {
                this.gender_confidenceField = value;
            }
        }

        /// <remarks/>
        public float glasses_confidence
        {
            get
            {
                return this.glasses_confidenceField;
            }
            set
            {
                this.glasses_confidenceField = value;
            }
        }

        /// <remarks/>
        public float height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFacesFaceInfoMask_areas mask_areas
        {
            get
            {
                return this.mask_areasField;
            }
            set
            {
                this.mask_areasField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFacesFaceInfoMeasurements measurements
        {
            get
            {
                return this.measurementsField;
            }
            set
            {
                this.measurementsField = value;
            }
        }

        /// <remarks/>
        public float mustache_confidence
        {
            get
            {
                return this.mustache_confidenceField;
            }
            set
            {
                this.mustache_confidenceField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFacesFaceInfoPoints points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public float score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }

        /// <remarks/>
        public float smile_confidence
        {
            get
            {
                return this.smile_confidenceField;
            }
            set
            {
                this.smile_confidenceField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFacesFaceInfoTags tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public BetafaceImageInfoResponseFacesFaceInfoUser_points user_points
        {
            get
            {
                return this.user_pointsField;
            }
            set
            {
                this.user_pointsField = value;
            }
        }

        /// <remarks/>
        public float width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMask_areas
    {

        private BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfo[] maskAreaInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaskAreaInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfo[] MaskAreaInfo
        {
            get
            {
                return this.maskAreaInfoField;
            }
            set
            {
                this.maskAreaInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfo
    {

        private string descriptionField;

        private int idField;

        private BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurements measurementsField;

        private string[] textField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public int id
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
        public BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurements measurements
        {
            get
            {
                return this.measurementsField;
            }
            set
            {
                this.measurementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurements
    {

        private BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurementsMeasurementValueInfo[] measurementValueInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementValueInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurementsMeasurementValueInfo[] MeasurementValueInfo
        {
            get
            {
                return this.measurementValueInfoField;
            }
            set
            {
                this.measurementValueInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMask_areasMaskAreaInfoMeasurementsMeasurementValueInfo
    {

        private string descriptionField;

        private float maxField;

        private float minField;

        private int typeField;

        private float valueField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public float max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        public float min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public int type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public float value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMeasurements
    {

        private BetafaceImageInfoResponseFacesFaceInfoMeasurementsMeasurementValueInfo[] measurementValueInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementValueInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoMeasurementsMeasurementValueInfo[] MeasurementValueInfo
        {
            get
            {
                return this.measurementValueInfoField;
            }
            set
            {
                this.measurementValueInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoMeasurementsMeasurementValueInfo
    {

        private string descriptionField;

        private float maxField;

        private float minField;

        private int typeField;

        private float valueField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public float max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        public float min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public int type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public float value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoPoints
    {

        private BetafaceImageInfoResponseFacesFaceInfoPointsPointInfo[] pointInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoPointsPointInfo[] PointInfo
        {
            get
            {
                return this.pointInfoField;
            }
            set
            {
                this.pointInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoPointsPointInfo
    {

        private int typeField;

        private float xField;

        private float yField;

        /// <remarks/>
        public int type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoTags
    {

        private BetafaceImageInfoResponseFacesFaceInfoTagsTagInfo[] tagInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TagInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoTagsTagInfo[] TagInfo
        {
            get
            {
                return this.tagInfoField;
            }
            set
            {
                this.tagInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoTagsTagInfo
    {

        private string nameField;

        private string valueField;

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
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoUser_points
    {

        private BetafaceImageInfoResponseFacesFaceInfoUser_pointsPointInfo[] pointInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointInfo")]
        public BetafaceImageInfoResponseFacesFaceInfoUser_pointsPointInfo[] PointInfo
        {
            get
            {
                return this.pointInfoField;
            }
            set
            {
                this.pointInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceImageInfoResponseFacesFaceInfoUser_pointsPointInfo
    {

        private int typeField;

        private float xField;

        private float yField;

        /// <remarks/>
        public int type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FaceRequestId
    {

        private string api_keyField;

        private string api_secretField;

        private string face_uidField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string face_uid
        {
            get
            {
                return this.face_uidField;
            }
            set
            {
                this.face_uidField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4016")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceFaceImageResponse
    {

        private int int_responseField;

        private string string_responseField;

        private byte[] face_imageField;

        private string uidField;

        /// <remarks/>
        public int int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public byte[] face_image
        {
            get
            {
                return this.face_imageField;
            }
            set
            {
                this.face_imageField = value;
            }
        }

        /// <remarks/>
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FacesRecognizeRequest
    {

        private string api_keyField;

        private string api_secretField;

        private string[] faces_uidsField;

        private string[] targetsField;

        private bool group_resultsField;

        private string[] textField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("guid", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public string[] faces_uids
        {
            get
            {
                return this.faces_uidsField;
            }
            set
            {
                this.faces_uidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public string[] targets
        {
            get
            {
                return this.targetsField;
            }
            set
            {
                this.targetsField = value;
            }
        }

        /// <remarks/>
        public bool group_results
        {
            get
            {
                return this.group_resultsField;
            }
            set
            {
                this.group_resultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceRecognizeRequestResponse
    {

        private uint int_responseField;

        private string string_responseField;

        private string recognize_uidField;

        /// <remarks/>
        public uint int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public string recognize_uid
        {
            get
            {
                return this.recognize_uidField;
            }
            set
            {
                this.recognize_uidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RecognizeResultRequest
    {

        private string api_keyField;

        private string api_secretField;

        private string recognize_uidField;

        /// <remarks/>
        public string api_key
        {
            get
            {
                return this.api_keyField;
            }
            set
            {
                this.api_keyField = value;
            }
        }

        /// <remarks/>
        public string api_secret
        {
            get
            {
                return this.api_secretField;
            }
            set
            {
                this.api_secretField = value;
            }
        }

        /// <remarks/>
        public string recognize_uid
        {
            get
            {
                return this.recognize_uidField;
            }
            set
            {
                this.recognize_uidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BetafaceRecognizeResponse
    {

        private uint int_responseField;

        private string string_responseField;

        private BetafaceRecognizeResponseFaces_matches faces_matchesField;

        private string recognize_uidField;

        private string[] textField;

        /// <remarks/>
        public uint int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public BetafaceRecognizeResponseFaces_matches faces_matches
        {
            get
            {
                return this.faces_matchesField;
            }
            set
            {
                this.faces_matchesField = value;
            }
        }

        /// <remarks/>
        public string recognize_uid
        {
            get
            {
                return this.recognize_uidField;
            }
            set
            {
                this.recognize_uidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceRecognizeResponseFaces_matches
    {

        private BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfo[] faceRecognizeInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FaceRecognizeInfo")]
        public BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfo[] FaceRecognizeInfo
        {
            get
            {
                return this.faceRecognizeInfoField;
            }
            set
            {
                this.faceRecognizeInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfo
    {

        private string face_uidField;

        private BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatches matchesField;

        private string[] textField;

        /// <remarks/>
        public string face_uid
        {
            get
            {
                return this.face_uidField;
            }
            set
            {
                this.face_uidField = value;
            }
        }

        /// <remarks/>
        public BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatches matches
        {
            get
            {
                return this.matchesField;
            }
            set
            {
                this.matchesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatches
    {

        private BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatchesPersonMatchInfo[] personMatchInfoField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonMatchInfo")]
        public BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatchesPersonMatchInfo[] PersonMatchInfo
        {
            get
            {
                return this.personMatchInfoField;
            }
            set
            {
                this.personMatchInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatchesPersonMatchInfo
    {

        private float confidenceField;

        private string face_uidField;

        private bool is_matchField;

        private string person_nameField;

        /// <remarks/>
        public float confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public string face_uid
        {
            get
            {
                return this.face_uidField;
            }
            set
            {
                this.face_uidField = value;
            }
        }

        /// <remarks/>
        public bool is_match
        {
            get
            {
                return this.is_matchField;
            }
            set
            {
                this.is_matchField = value;
            }
        }

        /// <remarks/>
        public string person_name
        {
            get
            {
                return this.person_nameField;
            }
            set
            {
                this.person_nameField = value;
            }
        }
    }
}
