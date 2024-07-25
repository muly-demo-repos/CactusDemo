import { MyEntItyWhereInput } from "./MyEntItyWhereInput";
import { MyEntItyOrderByInput } from "./MyEntItyOrderByInput";

export type MyEntItyFindManyArgs = {
  where?: MyEntItyWhereInput;
  orderBy?: Array<MyEntItyOrderByInput>;
  skip?: number;
  take?: number;
};
