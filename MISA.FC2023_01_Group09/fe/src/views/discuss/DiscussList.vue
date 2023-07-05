<template>
  <div class="discuss-list">
    <div class="discuss-header"></div>
    <div class="item-container">
      <DiscussListItem
        v-for="item in this.listQuestion"
        :key="item.QuestionId"
        :type="question"
        :title="item.QuestionTitle"
        :authorName="item.QuestionName"
        :totalResponse="130"
      ></DiscussListItem>
    </div>
    <DiscussResponseDetail hidden />
  </div>
</template>
<script>
import axios from "axios";
export default {
  name: "DiscussList",
  props: {},
  data() {
    return {
      listQuestion: [],
    };
  },
  methods: {
    async loadData() {
      var res = await axios.get("https://localhost:44370/api/v1/Questions");
      console.log("Data: ", res.data);
      this.listQuestion = res.data;
    },
  },
  created() {
    this.loadData();
  },
  computed: {},
};
</script>
<style scoped>
.discuss-list {
  background-color: #fff;
  border-radius: 4px;
  width: 100%;
  height: 100%;
  padding-left: 22px;
}

.discuss-header {
}

.discuss-list .item {
  border-bottom: 2px solid #eeeff1;
}

.discuss-list .item:last-child {
  border-bottom: none;
}

.item-container {
  height: 100%;
  overflow: auto;
  padding-right: 22px;
}
</style>
