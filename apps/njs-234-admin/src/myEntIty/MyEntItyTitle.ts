import { MyEntIty as TMyEntIty } from "../api/myEntIty/MyEntIty";

export const MYENTITY_TITLE_FIELD = "fld1";

export const MyEntItyTitle = (record: TMyEntIty): string => {
  return record.fld1?.toString() || String(record.id);
};
