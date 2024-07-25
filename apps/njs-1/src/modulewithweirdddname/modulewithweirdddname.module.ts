import { Module } from "@nestjs/common";
import { MOduleWithWeirDddNaMeService } from "./modulewithweirdddname.service";
import { MOduleWithWeirDddNaMeController } from "./modulewithweirdddname.controller";
import { MOduleWithWeirDddNaMeResolver } from "../MOduleWithWeirDddNaMe/modulewithweirdddname.resolver";

@Module({
  controllers: [MOduleWithWeirDddNaMeController],
  providers: [MOduleWithWeirDddNaMeService, MOduleWithWeirDddNaMeResolver],
  exports: [MOduleWithWeirDddNaMeService],
})
export class MOduleWithWeirDddNaMeModule {}
