import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as errors from "../errors";
import { MOduleWithWeirDddNaMeService } from "./modulewithweirdddname.service";

@swagger.ApiTags("mOduleWithWeirDddNaMes")
@common.Controller("mOduleWithWeirDddNaMes")
export class MOduleWithWeirDddNaMeController {
  constructor(protected readonly service: MOduleWithWeirDddNaMeService) {}

  @common.Get("/:id/wei-rda-c-tion")
  @swagger.ApiOkResponse({
    type: String
  })
  @swagger.ApiNotFoundResponse({
    type: errors.NotFoundException
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException
  })
  async WeiRdaCTion(
    @common.Body()
    body: string
  ): Promise<string> {
        return this.service.WeiRdaCTion(body);
      }
}
