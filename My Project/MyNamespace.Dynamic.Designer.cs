using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SBuilderXX.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAbout m_FrmAbout;

            public FrmAbout FrmAbout
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAbout = Create__Instance__(m_FrmAbout);
                    return m_FrmAbout;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAbout))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAbout);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAltitudeLine m_FrmAltitudeLine;

            public FrmAltitudeLine FrmAltitudeLine
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAltitudeLine = Create__Instance__(m_FrmAltitudeLine);
                    return m_FrmAltitudeLine;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAltitudeLine))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAltitudeLine);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAltitudePoly m_FrmAltitudePoly;

            public FrmAltitudePoly FrmAltitudePoly
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAltitudePoly = Create__Instance__(m_FrmAltitudePoly);
                    return m_FrmAltitudePoly;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAltitudePoly))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAltitudePoly);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmArcGisMap m_frmArcGisMap;

            public frmArcGisMap frmArcGisMap
            {
                [DebuggerHidden]
                get
                {
                    m_frmArcGisMap = Create__Instance__(m_frmArcGisMap);
                    return m_frmArcGisMap;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmArcGisMap))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmArcGisMap);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmBackground m_FrmBackground;

            public FrmBackground FrmBackground
            {
                [DebuggerHidden]
                get
                {
                    m_FrmBackground = Create__Instance__(m_FrmBackground);
                    return m_FrmBackground;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmBackground))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmBackground);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmBGL m_FrmBGL;

            public FrmBGL FrmBGL
            {
                [DebuggerHidden]
                get
                {
                    m_FrmBGL = Create__Instance__(m_FrmBGL);
                    return m_FrmBGL;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmBGL))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmBGL);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCalibrate m_FrmCalibrate;

            public FrmCalibrate FrmCalibrate
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCalibrate = Create__Instance__(m_FrmCalibrate);
                    return m_FrmCalibrate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCalibrate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCalibrate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmExcludesP m_FrmExcludesP;

            public FrmExcludesP FrmExcludesP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmExcludesP = Create__Instance__(m_FrmExcludesP);
                    return m_FrmExcludesP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmExcludesP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmExcludesP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmExtraMacro m_frmExtraMacro;

            public frmExtraMacro frmExtraMacro
            {
                [DebuggerHidden]
                get
                {
                    m_frmExtraMacro = Create__Instance__(m_frmExtraMacro);
                    return m_frmExtraMacro;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmExtraMacro))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmExtraMacro);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmExtrusions m_FrmExtrusions;

            public FrmExtrusions FrmExtrusions
            {
                [DebuggerHidden]
                get
                {
                    m_FrmExtrusions = Create__Instance__(m_FrmExtrusions);
                    return m_FrmExtrusions;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmExtrusions))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmExtrusions);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmFind m_FrmFind;

            public FrmFind FrmFind
            {
                [DebuggerHidden]
                get
                {
                    m_FrmFind = Create__Instance__(m_FrmFind);
                    return m_FrmFind;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmFind))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmFind);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmFSXSettings m_FrmFSXSettings;

            public FrmFSXSettings FrmFSXSettings
            {
                [DebuggerHidden]
                get
                {
                    m_FrmFSXSettings = Create__Instance__(m_FrmFSXSettings);
                    return m_FrmFSXSettings;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmFSXSettings))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmFSXSettings);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmGBuilding m_FrmGBuilding;

            public FrmGBuilding FrmGBuilding
            {
                [DebuggerHidden]
                get
                {
                    m_FrmGBuilding = Create__Instance__(m_FrmGBuilding);
                    return m_FrmGBuilding;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmGBuilding))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmGBuilding);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmGoogleMap m_frmGoogleMap;

            public frmGoogleMap frmGoogleMap
            {
                [DebuggerHidden]
                get
                {
                    m_frmGoogleMap = Create__Instance__(m_frmGoogleMap);
                    return m_frmGoogleMap;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmGoogleMap))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmGoogleMap);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmGotoPos m_FrmGotoPos;

            public FrmGotoPos FrmGotoPos
            {
                [DebuggerHidden]
                get
                {
                    m_FrmGotoPos = Create__Instance__(m_FrmGotoPos);
                    return m_FrmGotoPos;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmGotoPos))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmGotoPos);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmImage m_FrmImage;

            public FrmImage FrmImage
            {
                [DebuggerHidden]
                get
                {
                    m_FrmImage = Create__Instance__(m_FrmImage);
                    return m_FrmImage;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmImage))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmImage);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLandsP m_FrmLandsP;

            public FrmLandsP FrmLandsP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLandsP = Create__Instance__(m_FrmLandsP);
                    return m_FrmLandsP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLandsP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLandsP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLibrary m_FrmLibrary;

            public FrmLibrary FrmLibrary
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLibrary = Create__Instance__(m_FrmLibrary);
                    return m_FrmLibrary;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLibrary))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLibrary);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLinesP m_FrmLinesP;

            public FrmLinesP FrmLinesP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLinesP = Create__Instance__(m_FrmLinesP);
                    return m_FrmLinesP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLinesP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLinesP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLPPointsP m_FrmLPPointsP;

            public FrmLPPointsP FrmLPPointsP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLPPointsP = Create__Instance__(m_FrmLPPointsP);
                    return m_FrmLPPointsP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLPPointsP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLPPointsP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLPSample m_FrmLPSample;

            public FrmLPSample FrmLPSample
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLPSample = Create__Instance__(m_FrmLPSample);
                    return m_FrmLPSample;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLPSample))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLPSample);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLPSmooth m_FrmLPSmooth;

            public FrmLPSmooth FrmLPSmooth
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLPSmooth = Create__Instance__(m_FrmLPSmooth);
                    return m_FrmLPSmooth;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLPSmooth))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLPSmooth);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLWidth m_FrmLWidth;

            public FrmLWidth FrmLWidth
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLWidth = Create__Instance__(m_FrmLWidth);
                    return m_FrmLWidth;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLWidth))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLWidth);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmMapsP m_FrmMapsP;

            public FrmMapsP FrmMapsP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmMapsP = Create__Instance__(m_FrmMapsP);
                    return m_FrmMapsP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmMapsP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmMapsP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmObjectFolders m_FrmObjectFolders;

            public FrmObjectFolders FrmObjectFolders
            {
                [DebuggerHidden]
                get
                {
                    m_FrmObjectFolders = Create__Instance__(m_FrmObjectFolders);
                    return m_FrmObjectFolders;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmObjectFolders))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmObjectFolders);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmObjectsP m_FrmObjectsP;

            public FrmObjectsP FrmObjectsP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmObjectsP = Create__Instance__(m_FrmObjectsP);
                    return m_FrmObjectsP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmObjectsP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmObjectsP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmOrder m_FrmOrder;

            public FrmOrder FrmOrder
            {
                [DebuggerHidden]
                get
                {
                    m_FrmOrder = Create__Instance__(m_FrmOrder);
                    return m_FrmOrder;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmOrder))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmOrder);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmPolysP m_FrmPolysP;

            public FrmPolysP FrmPolysP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmPolysP = Create__Instance__(m_FrmPolysP);
                    return m_FrmPolysP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmPolysP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmPolysP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmProjectP m_FrmProjectP;

            public FrmProjectP FrmProjectP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmProjectP = Create__Instance__(m_FrmProjectP);
                    return m_FrmProjectP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmProjectP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmProjectP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmRAW m_FrmRAW;

            public FrmRAW FrmRAW
            {
                [DebuggerHidden]
                get
                {
                    m_FrmRAW = Create__Instance__(m_FrmRAW);
                    return m_FrmRAW;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmRAW))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmRAW);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSCREEN m_frmSCREEN;

            public frmSCREEN frmSCREEN
            {
                [DebuggerHidden]
                get
                {
                    m_frmSCREEN = Create__Instance__(m_frmSCREEN);
                    return m_frmSCREEN;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmSCREEN))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmSCREEN);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSHPLine m_FrmSHPLine;

            public FrmSHPLine FrmSHPLine
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSHPLine = Create__Instance__(m_FrmSHPLine);
                    return m_FrmSHPLine;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSHPLine))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSHPLine);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSHPPoly m_FrmSHPPoly;

            public FrmSHPPoly FrmSHPPoly
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSHPPoly = Create__Instance__(m_FrmSHPPoly);
                    return m_FrmSHPPoly;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSHPPoly))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSHPPoly);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmStart m_FrmStart;

            public FrmStart FrmStart
            {
                [DebuggerHidden]
                get
                {
                    m_FrmStart = Create__Instance__(m_FrmStart);
                    return m_FrmStart;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmStart))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmStart);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSurfer m_FrmSurfer;

            public FrmSurfer FrmSurfer
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSurfer = Create__Instance__(m_FrmSurfer);
                    return m_FrmSurfer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSurfer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSurfer);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTaxSign m_FrmTaxSign;

            public FrmTaxSign FrmTaxSign
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTaxSign = Create__Instance__(m_FrmTaxSign);
                    return m_FrmTaxSign;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTaxSign))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTaxSign);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTerrainExclude m_FrmTerrainExclude;

            public FrmTerrainExclude FrmTerrainExclude
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTerrainExclude = Create__Instance__(m_FrmTerrainExclude);
                    return m_FrmTerrainExclude;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTerrainExclude))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTerrainExclude);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmTexPoly m_frmTexPoly;

            public frmTexPoly frmTexPoly
            {
                [DebuggerHidden]
                get
                {
                    m_frmTexPoly = Create__Instance__(m_frmTexPoly);
                    return m_frmTexPoly;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmTexPoly))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmTexPoly);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTiles m_FrmTiles;

            public FrmTiles FrmTiles
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTiles = Create__Instance__(m_FrmTiles);
                    return m_FrmTiles;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTiles))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTiles);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmTilesServers m_frmTilesServers;

            public frmTilesServers frmTilesServers
            {
                [DebuggerHidden]
                get
                {
                    m_frmTilesServers = Create__Instance__(m_frmTilesServers);
                    return m_frmTilesServers;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmTilesServers))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmTilesServers);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTransparency m_FrmTransparency;

            public FrmTransparency FrmTransparency
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTransparency = Create__Instance__(m_FrmTransparency);
                    return m_FrmTransparency;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTransparency))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTransparency);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmWaiting m_frmWaiting;

            public frmWaiting frmWaiting
            {
                [DebuggerHidden]
                get
                {
                    m_frmWaiting = Create__Instance__(m_frmWaiting);
                    return m_frmWaiting;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmWaiting))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmWaiting);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmWatersP m_FrmWatersP;

            public FrmWatersP FrmWatersP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmWatersP = Create__Instance__(m_FrmWatersP);
                    return m_FrmWatersP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmWatersP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmWatersP);
                }
            }
        }
    }
}