module MatrixTypes

// Matrix2x2
type Matrix2x2(m00: float, m01: float, m10: float, m11: float) =
    member this.Determinant() =
        m00 * m11 - m01 * m10

// Matrix3x3
type Matrix3x3(m00: float, m01: float, m02: float, m10: float, m11: float, m12: float, m20: float, m21: float, m22: float) =
    member this.Determinant() =
        let c00 = (Matrix2x2(m11, m12, m21, m22)).Determinant()
        let c01 = -(Matrix2x2(m10, m12, m20, m22)).Determinant()
        let c02 = (Matrix2x2(m10, m11, m20, m21)).Determinant()
        m00 * c00 + m01 * c01 + m02 * c02

// Matrix4x4
type Matrix4x4(mV: float [,]) =
    member this.Determinant() =
        let c00 = (Matrix3x3(mV.[1,1], mV.[1,2], mV.[1,3], mV.[2,1], mV.[2,2], mV.[2,3], mV.[3,1], mV.[3,2], mV.[3,3])).Determinant()
        let c01 = -(Matrix3x3(mV.[1,0], mV.[1,2], mV.[1,3], mV.[2,0], mV.[2,2], mV.[2,3], mV.[3,0], mV.[3,2], mV.[3,3])).Determinant()
        let c02 = (Matrix3x3(mV.[1,0], mV.[1,1], mV.[1,3], mV.[2,0], mV.[2,1], mV.[2,3], mV.[3,0], mV.[3,1], mV.[3,3])).Determinant()
        let c03 = -(Matrix3x3(mV.[1,0], mV.[1,1], mV.[1,2], mV.[2,0], mV.[2,1], mV.[2,2], mV.[3,0], mV.[3,1], mV.[3,2])).Determinant()
        mV.[0,0] * c00 + mV.[0,1] * c01 + mV.[0,2] * c02 + mV.[0,3] * c03

