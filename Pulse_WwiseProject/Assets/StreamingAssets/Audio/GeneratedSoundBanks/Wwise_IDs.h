/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID CARENGINESTART = 2231332761U;
        static const AkUniqueID LEVELLOSE = 1070923030U;
        static const AkUniqueID LEVELSTART = 3372421815U;
        static const AkUniqueID LEVELWIN = 2487243565U;
        static const AkUniqueID MENUCLICK = 3711598968U;
        static const AkUniqueID MENUTEXT = 2607093533U;
        static const AkUniqueID RADIOSTART = 622084806U;
        static const AkUniqueID RADIOSTOP = 1232312710U;
        static const AkUniqueID TRIGGERALERT = 293751399U;
        static const AkUniqueID TRIGGERWARNING = 2319856225U;
        static const AkUniqueID TURNSIGNAL = 3858101368U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace RADIOOFF
        {
            static const AkUniqueID GROUP = 4221175997U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace RADIOOFF

        namespace RADIOON
        {
            static const AkUniqueID GROUP = 4245784721U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace RADIOON

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MASTERVOLUME = 2918011349U;
        static const AkUniqueID MUSICVOLUME = 2346531308U;
        static const AkUniqueID PLAYERSPEED = 1493153371U;
        static const AkUniqueID SFXVOLUME = 988953028U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
        static const AkUniqueID MUSIC = 3991942870U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID GUI = 915214414U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID WORLD = 2609808943U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
